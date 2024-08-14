using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Code_First_MVC.Models;

namespace CC1_Code_First.Controllers
{
    public class MoviesController : Controller
    {
        private MoviesContext db = new MoviesContext();
        // GET: Movies
        public ActionResult Index()
        {
            var movies = db.Movie.ToList();
            return View(movies);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movies movie)
        {
            if (ModelState.IsValid)
            {
                db.Movie.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            var movie = db.Movie.Find(id);
            return View(movie);
        }

        [HttpPost]
        public ActionResult Edit(Movies movie)
        {
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(movie);
        }

        public ActionResult Delete(int id)
        {
            var movie = db.Movie.Find(id);
            return View(movie);
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var movie = db.Movie.Find(id);
            db.Movie.Remove(movie);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult MoviesByYear(int year)
        {
            var movies = db.Movie.Where(m => m.DateofRelease.Year == year).ToList();
            ViewBag.Year = year;
            return View(movies);
        }
    }
}