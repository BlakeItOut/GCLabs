using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelFirstFramework.Models;

namespace ModelFirstFramework.Controllers
{
    public class DBController : Controller
    {
        private DevBuildMoviesDBEntities ORM = new DevBuildMoviesDBEntities();
        // GET: DB
        [Authorize]
        public ActionResult Index()
        {
            DevBuildMoviesDBEntities ORM = new DevBuildMoviesDBEntities();

            ViewBag.Movies = ORM.Movies;

            return View(ORM);
        }

        public ActionResult AddMovie()
        {
            return View();
        }

        public ActionResult AddDirector(int MovieID)
        {
            return View(ORM.Movies.Find(MovieID));
        }

        public ActionResult SaveAddDirector(Movie updatedMovie)
        {
            Movie movie = ORM.Movies.Find(updatedMovie.MovieID);

            movie.Director = new Director();
            movie.Director.FirstName = updatedMovie.Director.FirstName;
            movie.Director.LastName = updatedMovie.Director.LastName;

            if (!(ORM.Directors
                    .AsEnumerable()
                    .Select(dir => $"{dir.FirstName} {dir.LastName}")
                    .Contains($"{movie.Director.FirstName} {movie.Director.LastName}")))
            {
                ORM.Directors.Add(movie.Director);
                ORM.SaveChanges();
            }
            else
            {
                movie.Director = ORM.Directors
                                 .First<Director>(dir => dir.FirstName == movie.Director.FirstName && dir.LastName == movie.Director.LastName);
            }

            ORM.Entry(movie).State = System.Data.Entity.EntityState.Modified;
            ORM.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult EditMovie(int MovieId)
        {
            return View(ORM.Movies.Find(MovieId));
        }

        public ActionResult SaveMovieChanges(Movie updatedMovie)
        {
            Movie movie = ORM.Movies.Find(updatedMovie.MovieID);

            movie.Title = updatedMovie.Title;
            movie.Genre = updatedMovie.Genre;
            movie.Year = updatedMovie.Year;
            movie.Watched = updatedMovie.Watched;

            ORM.Entry(movie).State = System.Data.Entity.EntityState.Modified;
            ORM.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteMovie(int MovieID)
        {
            ORM.Movies.Remove(ORM.Movies.Find(MovieID));
            ORM.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult SaveNewMovie(Movie newMovie, Director newDirector)
        {
            if(!String.IsNullOrEmpty(newDirector.FirstName) || !String.IsNullOrEmpty(newDirector.LastName)) { 
                if(!(ORM.Directors
                                               .AsEnumerable()
                                               .Select(dir => $"{dir.FirstName} {dir.LastName}")
                                               .Contains($"{newDirector.FirstName} {newDirector.LastName}")))
                {
                    ORM.Directors.Add(newDirector);
                    ORM.SaveChanges();
                }
                else
                {
                    newDirector = ORM.Directors
                                     .First<Director>(dir => dir.FirstName == newDirector.FirstName && dir.LastName == newDirector.LastName);
                }
                newMovie.Director = newDirector;
            }
            if (ModelState.IsValid)
            {
                ORM.Movies.Add(newMovie);
                ORM.SaveChanges();
            }



            
            return RedirectToAction("Index");
        }
    }
}