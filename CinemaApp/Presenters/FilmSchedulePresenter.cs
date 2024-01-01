using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp._Repositories;
using CinemaApp.Data;
using CinemaApp.Models;
using CinemaApp.Views;

namespace CinemaApp.Presenters
{
    public class FilmSchedulePresenter
    {
        private IFilmScheduleView view;
        private IFilmScheduleRepository repository;
        private IMovieRepository movieRepository;

        private BindingSource filmBindingSource;
        private IEnumerable<FilmScheduleModel> filmList;
        private IEnumerable<MovieModel> movieList;

        public FilmSchedulePresenter(IFilmScheduleView view, IFilmScheduleRepository repository)
        {
            this.view = view;
            this.repository = repository;
            this.movieRepository = new MovieRepository(new CinemaAppContext());

            //Initialize binding source and film list
            filmBindingSource = new BindingSource();
            filmList = new List<FilmScheduleModel>();

            //Console.WriteLine("FilmSchedule Instance count: " + FilmScheduleView.InstanceInitializeCount);

            //if(FilmScheduleView.InstanceInitializeCount == 1)
            //{
                view.AddFilmScheduleEvent += AddFilmSchedule;
                view.SaveFilmScheduleEvent += SaveFilmSchedule;
                view.EditFilmScheduleEvent += EditFilmSchedule;
                view.SearchFilmScheduleEvent += SearchFilmSchedule;
                view.DeleteFilmScheduleEvent += DeleteFilmSchedule;
                view.CloseFormEvent += CloseFormEvent;
            //}

            LoadFilmSchedule();

            this.view.SetMovieListBindingSource(filmBindingSource);

            SetMovieComboBox();

            this.view.DisplayForm();
        }

        private void CloseFormEvent(object sender, EventArgs e)
        {
            LoadFilmSchedule();
        }

        private void DeleteFilmSchedule(object sender, EventArgs e)
        {
            try
            {
                var filmSchedule = (FilmScheduleModel)filmBindingSource.Current;
                repository.DeleteFilmSchedule(filmSchedule.Id);
                view.Message = "Film schedule successfully deleted.";
                LoadFilmSchedule();
            }catch (Exception ex)
            {
                view.Message = ex.Message;
            }
        }

        private void SearchFilmSchedule(object sender, EventArgs e)
        {
            bool isEmptyMovieValue = string.IsNullOrEmpty(this.view.SearchFilmScheduleValue);

            if (isEmptyMovieValue == false)
            {
                filmList = repository.GetFilmScheduleByMovieTitle(this.view.SearchFilmScheduleValue);
                filmBindingSource.DataSource = filmList;
            }
            else
            {
                filmList = repository.GetAllFilmSchedules();
                filmBindingSource.DataSource = filmList;
            }
        }

        private void SetMovieComboBox()
        {
            IEnumerable<MovieModel> movieList = movieRepository.GetAllMovies();
            this.movieList = movieList;
            view.SetMovieComboBox(movieList);
        }

        private void EditFilmSchedule (object sender, EventArgs e){
            view.IsEdit = true;
            var filmSchedule = (FilmScheduleModel)filmBindingSource.Current;
            view.Id = filmSchedule.Id;
            Console.WriteLine("Id: " + filmSchedule.Id);

            //Loop thorugh movieList find the Item has id equal to movieId of filmSchedule
            for (int i = 0; i < movieList.Count(); i++)
            {
                if (movieList.ElementAt(i).Id == filmSchedule.MovieId)
                {
                    view.Movie = movieList.ElementAt(i).Id.ToString();
                    Console.WriteLine("Movie: " + movieList.ElementAt(i).Id.ToString());
                }
            }

            view.Date = filmSchedule.Date.ToString("dd/MM/yyyy");
            view.StartTime = filmSchedule.StartTime;
            view.EndTime = filmSchedule.EndTime;
            view.Room = filmSchedule.CinemaId.ToString();
        }


        private void AddFilmSchedule(object sender, EventArgs e)
        {
            view.Date = "";
            view.StartTime = "";
            view.EndTime = "";
            view.Room = "1";
        }

        private void CheckRoomAndTimeAvailability(FilmScheduleModel model)
        {
            IEnumerable<FilmScheduleModel> filmSchedules = repository.GetAllFilmSchedules();

            foreach (var item in filmSchedules)
            {
                Console.WriteLine(" id:" + model.Id);
                if (model.Id == item.Id)
                {
                    continue;
                }
                //If cinema id and date equal, check time
                if (model.CinemaId == item.CinemaId && model.Date == item.Date)
                {
                    if (TimeSpan.Parse(model.StartTime) >= TimeSpan.Parse(item.StartTime) && TimeSpan.Parse(model.StartTime) <= TimeSpan.Parse(item.EndTime))
                    {
                        Console.WriteLine("Log 1");
                         throw new Exception("Room is not available at this time");
                    }
                    if (TimeSpan.Parse(model.EndTime) >= TimeSpan.Parse(item.StartTime) && TimeSpan.Parse(model.EndTime) <= TimeSpan.Parse(item.EndTime))
                    {
                        Console.WriteLine("Log 2");
                        throw new Exception("Room is not available at this time");
                    }
                }
            }
        }

        private void SaveFilmSchedule(object sender, EventArgs e)
        {
            try
            {
                int movieId = 0;
                movieId = int.Parse(view.Movie);
                if (movieId == 0) throw new Exception("Movie not found");


                MovieModel movie = movieRepository.GetMovieById(movieId);

                FilmScheduleModel model = new FilmScheduleModel();
                model.CinemaId = int.Parse(view.Room);
                model.StartTime = view.StartTime;
                model.MovieId = movieId;
                model.EndTime = TimeSpan.Parse(view.StartTime).Add(TimeSpan.Parse(movie.Duration)).ToString();
                model.Date = DateTime.ParseExact(view.Date, "dd/MM/yyyy", CultureInfo.InvariantCulture);

                if (model.Date < DateTime.Now.Date)
                {
                    throw new Exception("Date must be greater than or equal to today");
                }

                if (TimeSpan.Parse(model.StartTime) < TimeSpan.Parse("08:00:00") || TimeSpan.Parse(model.EndTime) > TimeSpan.Parse("19:00:00"))
                {
                    throw new Exception("Our cinema time works between 8:00 and 19:00");
                }

                new Utilities.ModelDataValidation().Validate(model);

                //Check room and time availability
                if (view.IsEdit)
                {
                    model.Id = Convert.ToInt32(view.Id);
                }

                this.CheckRoomAndTimeAvailability(model);

                new Utilities.ModelDataValidation().Validate(model);

                Console.WriteLine("No error");
                if (view.IsEdit)
                {
                    Console.WriteLine("Update");
                    repository.UpdateFilmSchedule(model);
                    view.Message = "Film schedule successfully updated.";
                }
                else
                {
                    repository.SaveFilmSchedule(model);
                    view.Message = "Film schedule successfully added.";
                }
            }

            catch(Exception ex)
            {
                this.view.Message = ex.Message;
                Console.WriteLine(ex.Message);
            }



        }




        private void LoadFilmSchedule()
        {
            filmList = repository.GetAllFilmSchedules();
            filmBindingSource.DataSource = filmList;
        }




    }
}
