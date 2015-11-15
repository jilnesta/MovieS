using MovieShopDAL;
using MovieShopDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace MovieShopRest.Controllers
{
    public class MovieController : ApiController
    {
       private Facade facade = new Facade();
        public IEnumerable<Movie> GetMovies()
        {
            return facade.GetMovieRepository().ReadAll();
        }

        public Movie GetMovie(int id)
        {
            return facade.GetMovieRepository().Find(id);
        }


        public void PostMovie(Movie movie)
        {
            facade.GetMovieRepository().Add(movie);

        }

        public void DeleteMovie(int id)
        {
            Movie movie = facade.GetMovieRepository().Find(id);
            if (movie == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            facade.GetMovieRepository().Delete(id);
        }

        public void PutMovie(int idd, Movie movie)
        {
            movie.Id = idd;
            facade.GetMovieRepository().Edit(movie);

        }

    }
}
