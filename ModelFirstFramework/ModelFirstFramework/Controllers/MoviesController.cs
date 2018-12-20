using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.EntityFramework;
using ModelFirstFramework.Models;
using Newtonsoft.Json;

namespace ModelFirstFramework.Controllers
{
    public class MoviesController : Controller
    {
        private DevBuildMoviesDBEntities db = new DevBuildMoviesDBEntities();
        private const string _userAgent = "Mozilla / 5.0(Windows NT 6.1; Win64; x64; rv: 47.0) Gecko / 20100101 Firefox / 47.0";
        // GET: Movies
        public ActionResult Index()
        {
            var movies = new List<Movie>();
            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:61568/api/movies/");

            request.UserAgent = _userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var serializer = new JsonSerializer();

                using (var data = new StreamReader(response.GetResponseStream()))
                using (var jsonReader = new JsonTextReader(data))
                {
                    movies = serializer.Deserialize<List<Movie>>(jsonReader);
                }

            }
            return View(movies);
        }

        // GET: Movies/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var movie = new Movie();

            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:61568/api/movies/{id}");

            request.UserAgent = _userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var serializer = new JsonSerializer();

                using (var data = new StreamReader(response.GetResponseStream()))
                using (var jsonReader = new JsonTextReader(data))
                {
                    movie = serializer.Deserialize<Movie>(jsonReader);
                }

            }

            
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // GET: Movies/Create
        public ActionResult Create()
        {
            var directors = new List<Director>();

            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:61568/api/directors/");

            request.UserAgent = _userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                var serializer = new JsonSerializer();

                using (var data = new StreamReader(response.GetResponseStream()))
                using (var jsonReader = new JsonTextReader(data))
                {
                    directors = serializer.Deserialize<List<Director>>(jsonReader);
                }

            }
            ViewBag.DirectorID = new SelectList(directors, "DirectorID", "LastName");
            return View();
        }

        // POST: Movies/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MovieID,Title,Genre,Year,DirectorID,Watched")] Movie movie)
        {
            var serializer = new JsonSerializer();
            if (ModelState.IsValid)
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://localhost:61568/api/movies/");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "POST";

                using (var writer = new StreamWriter(httpWebRequest.GetRequestStream()))
                using (var jsonWriter = new JsonTextWriter(writer))
                {
                    serializer.Serialize(jsonWriter, movie);
                }

                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                if (httpWebResponse.StatusCode == HttpStatusCode.Created)
                {
                    return RedirectToAction("Index");
                }               
            }

            var directors = new List<Director>();

            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:61568/api/directors/");

            request.UserAgent = _userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var data = new StreamReader(response.GetResponseStream()))
                using (var jsonReader = new JsonTextReader(data))
                {
                    directors = serializer.Deserialize<List<Director>>(jsonReader);
                }

            }

            ViewBag.DirectorID = new SelectList(directors, "DirectorID", "LastName", movie.DirectorID);
            return View(movie);
        }

        // GET: Movies/Edit/5
        public ActionResult Edit(int? id)
        {
            var serializer = new JsonSerializer();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var movie = new Movie();

            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:61568/api/movies/{id}");

            request.UserAgent = _userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var data = new StreamReader(response.GetResponseStream()))
                using (var jsonReader = new JsonTextReader(data))
                {
                    movie = serializer.Deserialize<Movie>(jsonReader);
                }

            }

            if (movie == null)
            {
                return HttpNotFound();
            }
            var directors = new List<Director>();

            HttpWebRequest request2 = WebRequest.CreateHttp($"http://localhost:61568/api/directors/");

            request2.UserAgent = _userAgent;

            HttpWebResponse response2 = (HttpWebResponse)request2.GetResponse();

            if (response2.StatusCode == HttpStatusCode.OK)
            {
                using (var data = new StreamReader(response2.GetResponseStream()))
                using (var jsonReader = new JsonTextReader(data))
                {
                    directors = serializer.Deserialize<List<Director>>(jsonReader);
                }

            }
            ViewBag.DirectorID = new SelectList(directors, "DirectorID", "LastName", movie.DirectorID);
            return View(movie);
        }

        // POST: Movies/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MovieID,Title,Genre,Year,DirectorID,Watched")] Movie movie)
        {
            var serializer = new JsonSerializer();
            if (ModelState.IsValid)
            {
                var httpWebRequest = (HttpWebRequest)WebRequest.Create($"http://localhost:61568/api/movies/{movie.MovieID}");
                httpWebRequest.ContentType = "application/json";
                httpWebRequest.Method = "PUT";

                using (var writer = new StreamWriter(httpWebRequest.GetRequestStream()))
                using (var jsonWriter = new JsonTextWriter(writer))
                {
                    serializer.Serialize(jsonWriter, movie);
                }

                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();

                if (httpWebResponse.StatusCode == HttpStatusCode.NoContent)
                {
                    return RedirectToAction("Index");
                }
            }
            var directors = new List<Director>();

            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:61568/api/directors/");

            request.UserAgent = _userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var data = new StreamReader(response.GetResponseStream()))
                using (var jsonReader = new JsonTextReader(data))
                {
                    directors = serializer.Deserialize<List<Director>>(jsonReader);
                }

            }
            ViewBag.DirectorID = new SelectList(directors, "DirectorID", "FirstName", movie.DirectorID);
            return View(movie);
        }

        // GET: Movies/Delete/5
        public ActionResult Delete(int? id)
        {
            var serializer = new JsonSerializer();
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var movie = new Movie();

            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:61568/api/movies/{id}");

            request.UserAgent = _userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                using (var data = new StreamReader(response.GetResponseStream()))
                using (var jsonReader = new JsonTextReader(data))
                {
                    movie = serializer.Deserialize<Movie>(jsonReader);
                }

            }
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"http://localhost:61568/api/movies/{id}");
            request.Method = "DELETE";

            request.UserAgent = _userAgent;

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            if (response.StatusCode == HttpStatusCode.OK)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
