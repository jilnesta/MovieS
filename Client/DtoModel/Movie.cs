using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DtoModel
{
   public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        [DataType("Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Year { get; set; }

        public double Price { get; set; }

        public virtual IEnumerable<Genre> Genres { get; set; }

        public String url { get; set; }
        public String Description { get; set; }

        public string MovieCoverUrl { get; set; }
    }
}
