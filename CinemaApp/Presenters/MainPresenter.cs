using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp._Repositories;
using CinemaApp.Data;
using CinemaApp.Views;

namespace CinemaApp.Presenters
{
    public class MainPresenter
    {

        private IMainView mainView;


        public MainPresenter(IMainView view)
        {
            this.mainView = view;
            this.mainView.ShowMovieView += ShowMoviesView;
            this.mainView.ShowCinemaView += ShowCinemaView;

            //Default view
            ShowMoviesView(null,null);
        }

        private void ShowMoviesView(object sender, EventArgs e)
        {
            IMovieView movieView = MovieView.GetInstance((Form)mainView);
            IMovieRepository movieRepository = new MovieRepository( new CinemaAppContext());
            new MoviePresenter(movieRepository,movieView);

        }

        private void ShowCinemaView(object sender, EventArgs e)
        {
           IFilmScheduleView filmScheduleView = FilmScheduleView.GetInstance((Form)mainView);
           IFilmScheduleRepository filmScheduleRepository = new FilmScheduleRepository(new CinemaAppContext());
           new FilmSchedulePresenter(filmScheduleView,filmScheduleRepository);
        }
    }
}
