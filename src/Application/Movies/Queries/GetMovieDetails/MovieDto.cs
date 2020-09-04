using AutoMapper;
using movie_db_app.Application.Common.Mappings;
using movie_db_app.Domain.Entities;
using System.Collections.Generic;

namespace movie_db_app.Application.Movies.Queries.GetMovieDetails
{
    public class MovieDto : IMapFrom<Movie>
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public float VoteAverage { get; set; }

        public string FormattedDate { get; set; }

        public string ImagePath { get; set; }

        public string BackgroundImagePath { get; set; }

        public int Runtime { get; set; }

        public string Overview { get; set; }

        public IList<Genre> Genres { get; set; }
    }
}

