using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Views
{
    public interface IMovieView
    {
        //Properties

        int MovieId { get; set; }
        string MovieTitle { get; set; }
        string MovieDescription { get; set; }
        string MovieImage { get; set; }
        string MovieGenre { get; set; }
        string MovieDuration { get; set; }
        string MovieReleaseDate { get; set; }

        string SearchMovieValue { get; set; }

        string Message { get; set; }

        bool IsSuccessful { get; set; }

        bool IsEdit { get; set; }

        static int InstanceInitializeCount { get; set; }


        //Events
        event EventHandler AddMovieEvent;

        event EventHandler DeleteMovieEvent;

        event EventHandler UpdateMovieEvent;

        event EventHandler GetAllMoviesEvent;

        event EventHandler SearchMovieEvent;

        event EventHandler SaveMovieEvent;

        event EventHandler CancelSaveMovieEvent;

        event EventHandler EditMovieEvent;


        //Methods

        void SetMovieListBindingSource(BindingSource movieList);


        void Show();



    }
}
