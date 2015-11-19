using DtoModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MovieShopGateway.Services
{
   public class GenreGatewayService
    {
        public IEnumerable<Genre> ReadAll()
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:53416/api/Genre/").Result;
                return response.Content.ReadAsAsync<IEnumerable<Genre>>().Result;
            }
        }

        public Genre Add(Genre Genre)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PostAsJsonAsync("http://localhost:53416/api/Genre/", Genre).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }

        public Genre Find(int? id)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.GetAsync("http://localhost:53416/api/Genre/" + id).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }
        }

        public void Delete(Genre Genre)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.DeleteAsync("http://localhost:53416/api/Genre/" + Genre.Id).Result;

            }
        }
        public Genre Update(Genre Genre)
        {
            using (var client = new HttpClient())
            {
                HttpResponseMessage response =
                    client.PutAsJsonAsync("http://localhost:53416/api/Genre?id=" + Genre.Id, Genre).Result;
                return response.Content.ReadAsAsync<Genre>().Result;
            }

        }
    }
}
