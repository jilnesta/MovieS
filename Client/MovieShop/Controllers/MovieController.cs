using DtoModel;
using MovieShop.Models;
using MovieShopGateway;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
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

        public ActionResult Create()
        {
            //IEnumerable<Genre> genres = facade.GetGenreGateway().ReadAll();
         
            var model = new CreateMovieViewModel() { Genres = new MultiSelectList(facade.GetGenreGateway().ReadAll(), "Id", "Name") };
            return View(model);
        }

        [HttpPost]
        public ActionResult Create(CreateMovieViewModel model)
        {
            if (model.SelectedGenres != null)
            {
                var newList = new List<Genre>();
                foreach (int id in model.SelectedGenres)
                {
                    newList.Add(new Genre() { Id = id });
                }
                model.Movie.Genres = newList;
            }
            facade.GetMovieGateway().Add(model.Movie);
            return RedirectToAction("Index", "Movie");
        }

        public ActionResult Delete(int? id)
        {
            Movie movie = facade.GetMovieGateway().Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            facade.GetMovieGateway().Delete(movie);
            return RedirectToAction("Index", "Movie");
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            //ViewBag.Genres = new SelectList(db.Genres, "Id", "Name");
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Movie movie = facade.GetMovieGateway().Find(id);
            var selectGenres = new List<int>();
            foreach (var item in movie.Genres)
            {
                selectGenres.Add(item.Id);
            }
            var model = new CreateMovieViewModel() {
                Movie = movie,
                Genres = new MultiSelectList(facade.GetGenreGateway().ReadAll(), "Id", "Name"),
                SelectedGenres = selectGenres
            };

            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "Id,Title,Year,Price,url,Description,MovieCoverUrl,Genre")] Movie movie)
        {

            //ViewBag.Genres = new SelectList(db.Genres, "Id", "Name");
            if (ModelState.IsValid)
            {

                facade.GetMovieGateway().Update(movie);
                return RedirectToAction("Index");
            }
            //facade.GetMovieRepository().Edit(movie);
            return View(movie);

        }

    }
}