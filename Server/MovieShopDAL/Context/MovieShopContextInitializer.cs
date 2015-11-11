using MovieShopDAL.DomainModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopDAL.Context
{
   public class MovieShopContextInitializer : DropCreateDatabaseAlways<MovieShopContext>
    {
        protected override void Seed(MovieShopContext context)
        {
            IList<Movie> movies = new List<Movie>();


            Genre genre1 = context.Genres.Add(new Genre() { Id = 1, Name = "Action" });
            Genre genre2 = context.Genres.Add(new Genre() { Id = 2, Name = "Science Fiction" });
            Genre genre3 = context.Genres.Add(new Genre() { Id = 3, Name = "Thriller" });

            //Customer customer1 = context.Customers.Add(new Customer() { Id = 1, Name = "Kim Cormen", Email = "Google@google.tinfoil", Password = "1234abcd" });

            movies.Add(new Movie()
            {
                Title = "The Dark Knight",
                Year = new DateTime(2008, 07, 22),
                Price = 200,
                MovieCoverUrl = "http://www.freedesign4.me/wp-content/gallery/posters/free-movie-film-poster-the_dark_knight_movie_poster.jpg",
                url = "https://www.youtube.com/embed/EXeTwQWrcwY",
                Genres = new List<Genre>() { genre1, genre2 },
                Description = "When the menace known as the Joker wreaks havoc and chaos on the people of Gotham, the caped crusader must come to terms with one of the greatest psychological tests of his ability to fight injustice.",
            });
            movies.Add(new Movie()
            {
                Title = "The Martian",
                Year = new DateTime(2015, 10, 19),
                Price = 250,
                MovieCoverUrl = "http://www.movienewz.com/img/gallery/martian/posters/martian_movie_poster_1.jpg",
                url = "https://www.youtube.com/embed/ej3ioOneTy8",
                Genres = new List<Genre>() { genre1 },
                Description = "During a manned mission to Mars, Astronaut Mark Watney is presumed dead after a fierce storm and left behind by his crew. But Watney has survived and finds himself stranded and alone on the hostile planet. With only meager supplies, he must draw upon his ingenuity, wit and spirit to subsist and find a way to signal to Earth that he is alive.",
            });
            movies.Add(new Movie()
            {
                Title = "Insurgent",
                Year = new DateTime(2015, 03, 11),
                Price = 150,
                MovieCoverUrl = "http://www.movienewz.com/img/gallery/insurgent/posters/insurgent_movie_poster_3.jpg",
                url = "https://www.youtube.com/embed/IR-l_TSjlEo",
                Genres = new List<Genre>() { genre2 },
                Description = "Beatrice Prior must confront her inner demons and continue her fight against a powerful alliance which threatens to tear her society apart with the help from others on her side.",
            });
            movies.Add(new Movie()
            {
                Title = "The Grey",
                Year = new DateTime(2012, 01, 12),
                Price = 150,
                MovieCoverUrl = "http://gdj.gdj.netdna-cdn.com/wp-content/uploads/2011/12/grey-movie-poster.jpg",
                url = "https://www.youtube.com/embed/Hfb0-U0ydj8",
                Genres = new List<Genre>() { genre2 },
                Description = "After their plane crashes in Alaska, six oil workers are led by a skilled huntsman to survival, but a pack of merciless wolves haunts their every step.",
            });
            movies.Add(new Movie()
            {
                Title = "Real Steel",
                Year = new DateTime(2012, 01, 12),
                Price = 150,
                MovieCoverUrl = "http://images5.fanpop.com/image/photos/26200000/Real-Steel-movie-posters-26233237-1079-1600.jpg",
                url = "https://www.youtube.com/embed/3S8a180uYBM",
                Genres = new List<Genre>() { genre2 },
                Description = "In the near future, robot boxing is a top sport. A struggling promoter feels he's found a champion in a discarded robot.",
            });
            movies.Add(new Movie()
            {
                Title = "The Expendables",
                Year = new DateTime(2010, 08, 20),
                Price = 150,
                MovieCoverUrl = "https://bandbent.files.wordpress.com/2012/08/expendables-2-movie-poster-comic-con-high-quality.jpg",
                url = "https://www.youtube.com/embed/C6RU5y2fU6s",
                Genres = new List<Genre>() { genre2 },
                Description = "A CIA operative hires a team of mercenaries to eliminate a Latin dictator and a renegade CIA agent.",
            });
            movies.Add(new Movie()
            {
                Title = "Harry Potter",
                Year = new DateTime(2007, 07, 11),
                Price = 150,
                MovieCoverUrl = "http://www.freedesign4.me/wp-content/gallery/posters/free-movie-film-poster-harry-potter-phoenix.jpg",
                url = "https://www.youtube.com/embed/CQAX-YwX6iM",
                Genres = new List<Genre>() { genre2 },
                Description = "Rescued from the outrageous neglect of his aunt and uncle, a young boy with a great destiny proves his worth while attending Hogwarts School of Witchcraft and Wizardry.",
            });
            movies.Add(new Movie()
            {
                Title = "Thor",
                Year = new DateTime(2011, 03, 28),
                Price = 150,
                MovieCoverUrl = "http://blog.moviepostershop.com/wp-content/uploads/2011/03/Thor-movie-poster.jpg",
                url = "https://www.youtube.com/embed/JOddp-nlNvQ",
                Genres = new List<Genre>() { genre2 },
                Description = "The powerful but arrogant god Thor is cast out of Asgard to live amongst humans in Midgard (Earth), where he soon becomes one of their finest defenders.",
            });
            movies.Add(new Movie()
            {
                Title = "James Bond - Skyfall",
                Year = new DateTime(2015, 03, 11),
                Price = 150,
                MovieCoverUrl = "http://www.printmag.com/wp-content/uploads/skyfall_xlg.jpg",
                url = "https://www.youtube.com/embed/6kw1UVovByw",
                Genres = new List<Genre>() { genre2 },
                Description = "Bond's loyalty to M is tested when her past comes back to haunt her. Whilst MI6 comes under attack, 007 must track down and destroy the threat, no matter how personal the cost.",
            });
            movies.Add(new Movie()
            {
                Title = "James Bond - Quantum of Solace",
                Year = new DateTime(2008, 11, 14),
                Price = 150,
                MovieCoverUrl = "http://images2.fanpop.com/images/photos/8400000/Movie-Posters-movies-8405072-1723-2560.jpg",
                url = "https://www.youtube.com/embed/f6acw690AqQ",
                Genres = new List<Genre>() { genre2 },
                Description = "James Bond descends into mystery as he tries to stop a mysterious organization from eliminating a country's most valuable resource. All the while, he still tries to seek revenge over the death of his love.",
            });

            foreach (Movie mov in movies)
                context.Movies.Add(mov);



            base.Seed(context);
        }
    }
}
