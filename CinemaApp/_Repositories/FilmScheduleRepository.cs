using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp.Data;
using CinemaApp.Models;

namespace CinemaApp._Repositories
{
    public class FilmScheduleRepository : IFilmScheduleRepository
    {
        private readonly CinemaAppContext _context;

        public FilmScheduleRepository(CinemaAppContext context)
        {
            _context = context;
        }

        public void AddFilmSchefule(FilmScheduleModel filmSchedule)
        {
            throw new NotImplementedException();
        }

        public void DeleteFilmSchedule(int id)
        {
            _context.FilmSchedules.Remove(_context.FilmSchedules.Find(id));
            _context.SaveChanges();
        }

        public IEnumerable<FilmScheduleModel> GetAllFilmSchedules()
        {
            return _context.FilmSchedules.ToList();
        }

        public IEnumerable<FilmScheduleModel> GetFilmScheduleByMovieTitle(string searchValue)
        {
           //Get list movies id base on search value and convert to list and get film schedule list base on movie id
           var movieList = _context.Movies.Where(m => m.Title.Contains(searchValue)).ToList();

           var filmScheduleList = _context.FilmSchedules.ToList().Where(f => movieList.Any(m => m.Id == f.MovieId)).ToList();

            return filmScheduleList;
        }

        public void UpdateFilmSchefule(FilmScheduleModel filmSchedule)
        {
            throw new NotImplementedException();
        }

        public void SaveFilmSchedule(FilmScheduleModel filmSchedule)
        {
          _context.FilmSchedules.Add(filmSchedule);
          _context.SaveChanges();
        }

        void IFilmScheduleRepository.UpdateFilmSchedule(FilmScheduleModel model)
        {
            var filmSchedule = _context.FilmSchedules.Find(model.Id);
            _context.Entry(filmSchedule).CurrentValues.SetValues(model);
            _context.SaveChanges();
        }
    }
}
