using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoModel
{
   public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public DateTime Year { get; set; }

        public double Price { get; set; }

        public ICollection<Genre> Genres { get; set; }

        public String url { get; set; }
        public String Description { get; set; }

        public string MovieCoverUrl { get; set; }
    }
}
