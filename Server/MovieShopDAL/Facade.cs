using MovieShopDAL.DomainModel;
using MovieShopDAL.Repository;
using MovieShopDAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL
{
    public class Facade
    {
//        System.Data.Entity.SqlServer.SqlProviderServices
//sqlprovider = System.Data.Entity.SqlServer.SqlProviderServices.Instance;

        private IRepository<Movie> movieRepo;
        private IRepository<Genre> genreRepo;

        public IRepository<Movie> GetMovieRepository()
        {
            if (movieRepo == null)
            {
                movieRepo = new MovieRepository();
                //Movie = new FrogEatsFrogRepo();
            }
            return movieRepo;
        }
        public IRepository<Genre> GetGenresRepository()
        {
            if (genreRepo == null)
            {
                genreRepo = new GenreRepository();
            }
            return genreRepo;
        }
    }
}
