using AutoMapper;
using movie_db_app.Application.Common.Mappings;
using movie_db_app.Domain.Entities;
using System.Collections.Generic;

namespace movie_db_app.Application.Movies.Queries.DiscoverMovies
{
    public class MovieListDto : IMapFrom<MovieList>
    {
        public MovieListDto()
        {
            Items = new List<MovieBannerDto>();
        }

        public int Page { get; set; }

        public int TotalItems { get; set; }

        public int TotalPages { get; set; }

        public IList<MovieBannerDto> Items { get; set; }
    }
}
