using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp.Models;

namespace CinemaApp._Repositories
{
    public interface IFilmScheduleRepository
    {
        void AddFilmSchefule(Models.FilmScheduleModel filmSchedule);
        void DeleteFilmSchedule(int id);
        void UpdateFilmSchefule(Models.FilmScheduleModel filmSchedule);

        void SaveFilmSchedule(FilmScheduleModel filmSchedule);
        IEnumerable<Models.FilmScheduleModel> GetAllFilmSchedules();
        IEnumerable<Models.FilmScheduleModel> GetFilmScheduleByMovieTitle(string searchValue);
        void UpdateFilmSchedule(FilmScheduleModel model);
    }
}
