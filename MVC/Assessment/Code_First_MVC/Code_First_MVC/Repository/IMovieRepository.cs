using Code_First_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_MVC.Repository
{
    public interface IMovieRepository : IDisposable
    {
        IEnumerable<Movie> GetAllMovies();
        Movie GetMovieById(int id);
        void InsertMovie(Movie movie);
        void UpdateMovie(Movie movie);
        void DeleteMovie(int id);
        void Save();
    }
}