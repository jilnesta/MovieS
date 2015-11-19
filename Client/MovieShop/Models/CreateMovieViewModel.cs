using DtoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieShop.Models
{
    public class CreateMovieViewModel
    {
        public Movie Movie { get; set; }

        public MultiSelectList Genres { get; set; }
        public List<int> SelectedGenres { get; set; }
    }
}