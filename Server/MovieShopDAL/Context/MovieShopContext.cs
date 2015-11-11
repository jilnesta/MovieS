using DelegateDecompiler;
using MovieShopDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL.Context
{
   public class MovieShopContext : DbContext
    {
        public MovieShopContext() : base("MovieShopDBs")
        {
            Database.SetInitializer(new MovieShopContextInitializer());

            //Add this line to make json conversin happy.
            Configuration.ProxyCreationEnabled = false;
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasMany(g => g.Genres).WithMany();
        }
        //OnModelCreating States exactly which lists the tables are connected as many-to-many through

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Genre> Genres { get; set; }
    }
}
