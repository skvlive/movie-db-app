using movie_db_app.Domain.Entities;
using System.Threading.Tasks;

namespace movie_db_app.Application.Common.Interfaces
{
    public interface IMovieService
    {
        Task<MovieList> DiscoverMovies();
        Task<Movie> GetMovieDetails(int id);
    }
}
