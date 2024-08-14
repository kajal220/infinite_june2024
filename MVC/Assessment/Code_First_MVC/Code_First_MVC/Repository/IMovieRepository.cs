using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_First_MVC.Repository
{
    public interface IMovieRepository<T> where T : class
    {
        IEnumerable<T> GetAll(); //for all products
        IEnumerable<T> GetMoviesByYear(int year);
        T GetById(object Id); //for a particular product
        void Insert(T obj);
        void Update(T obj);
        void Delete(object Id);
        void Save();
    }
}