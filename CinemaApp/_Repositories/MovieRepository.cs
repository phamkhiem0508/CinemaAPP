using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp.Data;
using CinemaApp.Models;

namespace CinemaApp._Repositories
{
    public class MovieRepository: IMovieRepository
    {
        private readonly CinemaAppContext _context;

        public MovieRepository(CinemaAppContext context)
        {
            _context = context;
        }

        public void AddMovie(MovieModel movie)
        {
            _context.Movies.Add(movie);
            _context.SaveChanges();
        }

        public void DeleteMovie(int id)
        {
            var movie = _context.Movies.Find(id);
            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public IEnumerable<MovieModel> GetAllMovies()
        {
            return _context.Movies.ToList();
        }

        public IEnumerable<MovieModel> GetMovieByTitle(string title)
        {
            return _context.Movies.Where(m => m.Title.Contains(title)).ToList();
        }

        public void UpdateMovie(MovieModel movie)
        {
            int movieID = movie.Id;
            var movieToUpdate = _context.Movies.Find(movieID);
            _context.Entry(movieToUpdate).CurrentValues.SetValues(movie);
            _context.SaveChanges();
        }

        public MovieModel GetMovieById(int id)
        {
            return _context.Movies.Find(id);
        }

    }   
}
