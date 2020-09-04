using AutoMapper;
using AutoMapper.QueryableExtensions;
using movie_db_app.Application.Common.Interfaces;
using movie_db_app.Domain.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using movie_db_app.Domain.Entities;
using System.Collections.Generic;

namespace movie_db_app.Application.Movies.Queries.DiscoverMovies
{
    public class DiscoverMovies : IRequest<MoviesVm>
    {
    }

    public class DiscoverMoviesQueryHandler : IRequestHandler<DiscoverMovies, MoviesVm>
    {
        private readonly IMovieService _service;
        private readonly IMapper _mapper;

        public DiscoverMoviesQueryHandler(IMovieService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<MoviesVm> Handle(DiscoverMovies request, CancellationToken cancellationToken)
        {
            var result = await _service.DiscoverMovies();
            return new MoviesVm
            {
                List = _mapper.Map<MovieListDto>(result)
            };
        }
    }
}
