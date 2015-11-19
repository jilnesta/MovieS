using MovieShopDAL.Context;
using MovieShopDAL.DomainModel;
using MovieShopDAL.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL.Repository
{
    public class GenreRepository : IRepository<Genre>
    {
        private List<Genre> genres = new List<Genre>();
        public void Add(Genre item)
        {
            using (var ctx = new MovieShopContext())
            {
                //Create the queries
                ctx.Genres.Add(item);
                //Execute the queries
                ctx.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            Genre item = Find(id);
            using (var ctx = new MovieShopContext())
            {
                ctx.Genres.Attach(item);

                //var thisMovie =  ctx.Movies.Where(x => x.Id == movie.Id).FirstOrDefault();
                ctx.Genres.Remove(item);
                ctx.SaveChanges();
            }
        }

        public void Edit(Genre item)
        {
            using (var ctx = new MovieShopContext())
            {


                //A gift to Lars from KBTZ team. Enjoy!
                var genreDB = ctx.Genres.FirstOrDefault(x => x.Id == item.Id);
                //genreDB.Genres = ctx.Genres.FirstOrDefault(x => x.Id == movie.Genres.Id);
                genreDB.Name = item.Name;

                ctx.SaveChanges();

            }
        }

        public List<Genre> ReadAll()
        {
            using (var ctx = new MovieShopContext())
            {
                return ctx.Genres.ToList();
            }
        }
        public Genre Find(int id)
        {
            foreach(var item in ReadAll())
                {
                if (item.Id == id)
                {
                    return item;
                }

            }
            return null;
        }
    }
    
}
