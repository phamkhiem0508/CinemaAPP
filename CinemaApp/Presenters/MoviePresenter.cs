using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp._Repositories;
using CinemaApp.Models;
using CinemaApp.Views;

namespace CinemaApp.Presenters
{
    public class MoviePresenter
    {

        //Fields
        private IMovieRepository repository;
        private IMovieView view;

        private BindingSource movieBindingSource;
        private IEnumerable<MovieModel> movieList;

        //Constructor
        public MoviePresenter(IMovieRepository repository, IMovieView view)
        {
            this.repository = repository;
            this.view = view;

            //Initialize binding source and movie list
            movieBindingSource = new BindingSource();
            movieList = new List<MovieModel>();

            //Subscribe to view events

            //Console.WriteLine("Movie Instance count: " + MovieView.InstanceInitializeCount);

            //if(MovieView.InstanceInitializeCount == 1)
            //{
                this.view.SearchMovieEvent += SearchMovie;
                this.view.GetAllMoviesEvent += GetAllMovies;
                this.view.AddMovieEvent += AddMovie;
                this.view.DeleteMovieEvent += DeleteMovie;
                this.view.UpdateMovieEvent += UpdateMovie;
                this.view.SaveMovieEvent += SaveMovie;
                this.view.CancelSaveMovieEvent += CancelSaveMovie;
                this.view.EditMovieEvent += EditMovie;
           //}



            LoadAllMovieList();

            //Set movie list binding source
            this.view.SetMovieListBindingSource(movieBindingSource);

            this.view.Show();
        }

        //Methods
        private void LoadAllMovieList()
        {
            movieList = repository.GetAllMovies();
            movieBindingSource.DataSource = movieList;
        }

        private void GetAllMovies(object sender, EventArgs e)
        {
           
        }

        private void EditMovie(object sender, EventArgs e)
        {
            var movie = (MovieModel)movieBindingSource.Current;

            this.view.MovieTitle = movie.Title;
            this.view.MovieDescription = movie.Description;
            this.view.MovieDuration = movie.Duration;
            this.view.MovieReleaseDate = movie.ReleaseDate;
            this.view.MovieGenre = movie.Genre;
            this.view.MovieImage = movie.Image;
            this.view.MovieId = movie.Id;

        }

        private void SearchMovie(object sender, EventArgs e)
        {
            bool isEmptyMovieValue = string.IsNullOrEmpty(this.view.SearchMovieValue);

            if (isEmptyMovieValue == false)
            {
                movieList = repository.GetMovieByTitle(this.view.SearchMovieValue);
                movieBindingSource.DataSource = movieList;
            }
            else
            {
                movieList = repository.GetAllMovies();
                movieBindingSource.DataSource = movieList;
            }
        }

        private void AddMovie(object sender, EventArgs e)
        {

            //Reset default value
            this.view.MovieTitle = "";
            this.view.MovieDescription = "";
            this.view.MovieDuration = "";
            this.view.MovieReleaseDate = "";
            this.view.MovieGenre = "";
            this.view.MovieImage = "";
        }

        private void DeleteMovie(object sender, EventArgs e)
        {
            try
            {
                var movie = (MovieModel)movieBindingSource.Current;
                repository.DeleteMovie(movie.Id);
                this.view.Message = "Movie successfully deleted.";
                LoadAllMovieList();
            }catch(Exception ex)
            {
                this.view.Message = ex.Message;
            }
           

          

        }

        private void UpdateMovie(object sender, EventArgs e)
        {
            
        }

        private void SaveMovie(object sender, EventArgs e)
        {
            var model = new MovieModel();
            model.Title = this.view.MovieTitle;
            model.Description = this.view.MovieDescription;
            model.Duration = this.view.MovieDuration.Trim();
            model.ReleaseDate = this.view.MovieReleaseDate.Trim();
            model.Genre = this.view.MovieGenre;
            model.Image = "Test image url";
            Console.WriteLine("Add movies");
            try
            {
                new Utilities.ModelDataValidation().Validate(model);

                if (view.IsEdit)
                {
                    model.Id = Convert.ToInt32(view.MovieId);
                    repository.UpdateMovie(model);
                    view.Message = "Movie successfully updated.";
                }
                else
                {
                    repository.AddMovie(model);
                    view.Message = "Movie successfully added.";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                this.view.Message = ex.Message;
            }
        }

        private void CancelSaveMovie(object sender, EventArgs e)
        {
            Console.WriteLine("Cancel save movie");
            LoadAllMovieList();
        }
    }
}
