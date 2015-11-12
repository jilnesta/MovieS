using DtoModel;
using MovieShopGateway;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShop.Controllers
{
    
    public class MovieController : Controller
    {
        private Facade facade = new Facade();
        // GET: Movie
        public ActionResult Index()
        {
            IEnumerable<Movie> movies = facade.GetMovieGateway().ReadAll();
            Debug.WriteLine(movies);
            return View(movies);
        }

        public ActionResult Create()
        {
            Movie movie = new Movie() { Genres = new List<Genre>(), MovieCoverUrl = "pic2", Price = 120, Year = DateTime.Now, Description = "Good moviee", Title = "MovieKris", url = "url1" };
            facade.GetMovieGateway().Add(movie);
            return View();
        }
    }
}