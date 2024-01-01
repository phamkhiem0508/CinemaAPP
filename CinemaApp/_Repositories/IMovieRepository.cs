using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CinemaApp.Models;

namespace CinemaApp._Repositories
{
    public interface IMovieRepository
    {

        void AddMovie(MovieModel movie);

        void DeleteMovie(int id);

        void UpdateMovie(MovieModel movie);
        IEnumerable<MovieModel> GetAllMovies();
        IEnumerable<MovieModel> GetMovieByTitle(string title);
        MovieModel GetMovieById(int id);

    }
}
