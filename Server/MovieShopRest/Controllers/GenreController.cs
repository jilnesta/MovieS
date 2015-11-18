
using MovieShopDAL;
using MovieShopDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GenreShopRest.Controllers
{
    public class GenreController : ApiController
    {
        private Facade facade = new Facade();
        public IEnumerable<Genre> GetGenres()
        {
            return facade.GetGenresRepository().ReadAll();
        }

        public Genre GetGenre(int id)
        {
            return facade.GetGenresRepository().Find(id);
        }


        public void PostGenre(Genre Genre)
        {
            facade.GetGenresRepository().Add(Genre);

        }

        public void DeleteGenre(int id)
        {
            Genre Genre = facade.GetGenresRepository().Find(id);
            if (Genre == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            facade.GetGenresRepository().Delete(id);
        }

        public void PutGenre(int id, Genre Genre)
        {
            Genre.Id = id;
            facade.GetGenresRepository().Edit(Genre);

        }

    }
}
