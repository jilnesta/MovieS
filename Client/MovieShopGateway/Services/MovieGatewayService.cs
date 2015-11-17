using DtoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopGateway.Services
{
    public class MovieGatewayService
    {
        public IEnumerable<Movie> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:44334/api/movie/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Movie>>().Result;
            }
        }

        public Movie Add(Movie movie)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:44334/api/movie/", movie).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public Movie Find(int? id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:44334/api/movie/" + id).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
        }

        public void Delete(Movie movie)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:44334/api/movie/" + movie.Id).Result;

            }
        }
        public Movie Update(Movie movie)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync("http://localhost:44334/api/movie?id=" + movie.Id, movie).Result;
                return response.Content.ReadAsAsync<Movie>().Result;
            }
           
        }
    


    }
}
