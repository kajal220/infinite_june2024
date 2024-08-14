using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_First_MVC.Models;
using Code_First_MVC.Repository;

namespace Code_First_MVC.Controllers
{
    public class MoviesController : Controller
    {
        public IMovieRepository movieRepository;

        public MoviesController()
        {
            this.movieRepository = new MovieRepository(new MoviesDbContext());
        }

       
        public ActionResult Index()
        {
            var movies = movieRepository.GetAllMovies();
            return View(movies);
        }

     
        public ActionResult Create()
        {
            return View();
        }

       
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Mid,MovieName,DateOfRelease")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                movieRepository.InsertMovie(movie);
                movieRepository.Save();
                return RedirectToAction("Index");
            }

            return View(movie);
        }

        
        public ActionResult Edit(int id)
        {
            Movie movie = movieRepository.GetMovieById(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Mid,MovieName,DateOfRelease")] Movie movie)
        {
            if (ModelState.IsValid)
            {
                movieRepository.UpdateMovie(movie);
                movieRepository.Save();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        
        public ActionResult Delete(int id)
        {
            Movie movie = movieRepository.GetMovieById(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            movieRepository.DeleteMovie(id);
            movieRepository.Save();
            return RedirectToAction("Index");
        }

        
        public ActionResult ReleasedInYear(int year)
        {
            var movies = movieRepository.GetAllMovies()
                                         .Where(m => m.DateOfRelease.Year == year)
                                         .ToList();
            return View(movies);
        }
    }
}