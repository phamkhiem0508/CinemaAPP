using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp.Models;

namespace CinemaApp.Views
{
    public interface IFilmScheduleView
    {
        //Properties
        int Id { get; set; }
        string Movie { get; set; }
        string Date { get; set; }
        string StartTime { get; set; }
        string EndTime { get; set; }

        string Room { get; set; }

        string Message { get; set; }

        bool IsEdit { get; set; }

        string SearchFilmScheduleValue { get; set; }

        static int InstanceInitializeCount { get; set; }

        //Events
        event EventHandler AddFilmScheduleEvent;
        event EventHandler EditFilmScheduleEvent;
        event EventHandler LoadFilmScheduleEvent;
        event EventHandler UpdateFilmScheduleEvent;
        event EventHandler DeleteFilmScheduleEvent;
        event EventHandler SearchFilmScheduleEvent;
        event EventHandler SaveFilmScheduleEvent;
        event EventHandler CloseFormEvent;

        //Methods

        //Methods
        void SetMovieListBindingSource(BindingSource movieList);

        void SetMovieComboBox(IEnumerable<MovieModel> movies);

        void DisplayForm();
    }
}
