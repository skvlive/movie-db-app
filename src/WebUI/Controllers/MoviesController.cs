using movie_db_app.Application.Movies.Queries.DiscoverMovies;
using movie_db_app.Application.Movies.Queries.GetMovieDetails;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace movie_db_app.WebUI.Controllers
{
    public class MoviesController : ApiController
    {
        [HttpGet]
        public async Task<ActionResult<MoviesVm>> GetMovies()
        {
            return await Mediator.Send(new DiscoverMovies());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<MovieVm>> GetMovie(int id)
        {
            return await Mediator.Send(new GetMovieDetails { Id = id });
        }
    }
}
