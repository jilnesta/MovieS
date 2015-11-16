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
            //TEST
            IEnumerable<Movie> movies = facade.GetMovieGateway().ReadAll();
            Debug.WriteLine(movies);
            return View(movies);
        }

        public ActionResult Create(Movie movie)
        {

            facade.GetMovieGateway().Add(movie);
            return View();
        }

        public ActionResult Delete(int id)
        {
            Movie movie = facade.GetMovieGateway().Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            facade.GetMovieGateway().Delete(movie);
            return RedirectToAction("Index", "Movie");
        }
        public ActionResult PutMovie(int id, Movie movie)
        {
            movie.Id = id;
            facade.GetMovieGateway().Update(movie);
            return View(movie);

        }

    }
}