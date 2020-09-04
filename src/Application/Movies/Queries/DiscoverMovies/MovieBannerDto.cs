using AutoMapper;
using movie_db_app.Application.Common.Mappings;
using movie_db_app.Domain.Entities;

namespace movie_db_app.Application.Movies.Queries.DiscoverMovies
{
    public class MovieBannerDto : IMapFrom<MovieBanner>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public float VoteAverage { get; set; }

        public string FormattedDate { get; set; }

        public string ImagePath { get; set; }
    }
}

