using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Bidyo.Models;

namespace Bidyo.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            var movies = GetMovies();

            return View(movies);
        }

        //Create a list of movies
        private IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>
            {
                new Movie { Id = 1 , Name = "Parasite"},
                new Movie { Id = 2, Name = "Joker"},
                new Movie { Id = 3, Name = "1917"}
            };
        }
    }
}