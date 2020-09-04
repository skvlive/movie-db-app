using movie_db_app.Application.Common.Interfaces;
using System.Threading.Tasks;
using System.Net.Http;
using movie_db_app.Domain.Entities;
using Newtonsoft.Json;

namespace movie_db_app.Infrastructure.Services
{
    public class MovieService : IMovieService
    {
        public async Task<MovieList> DiscoverMovies()
        {
            MovieList list = null;
            string requestUrl = new RequestBuilder()
                            .Discover()
                            .TypeMovie()
                            .InLanguage("en-US")
                            .WithRatingGTE(7)
                            .SortBy("popularity.desc")
                            .Build();
            using (var http = new HttpClient())
            {
                HttpResponseMessage response = await http.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    var resp = await response.Content.ReadAsStringAsync();
                    list = JsonConvert.DeserializeObject<MovieList>(resp);
                }
            }
            return list;
        }

        public async Task<Movie> GetMovieDetails(int id)
        {
            Movie details = null;
            string requestUrl = new RequestBuilder()
                            .WithId("movie", id)
                            .Build();
            using (var http = new HttpClient())
            {
                HttpResponseMessage response = await http.GetAsync(requestUrl);
                if (response.IsSuccessStatusCode)
                {
                    var resp = await response.Content.ReadAsStringAsync();
                    details = JsonConvert.DeserializeObject<Movie>(resp);
                }
            }
            return details;

        }

    }
}
