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

namespace movie_db_app.Application.Movies.Queries.GetMovieDetails
{
    public class GetMovieDetails : IRequest<MovieVm>
    {
        public int Id { get; set; }
    }

    public class GetMovieDetailsQueryHandler : IRequestHandler<GetMovieDetails, MovieVm>
    {
        private readonly IMovieService _service;
        private readonly IMapper _mapper;

        public GetMovieDetailsQueryHandler(IMovieService service, IMapper mapper)
        {
            _service = service;
            _mapper = mapper;
        }

        public async Task<MovieVm> Handle(GetMovieDetails request, CancellationToken cancellationToken)
        {
            var result = await _service.GetMovieDetails(request.Id);
            return new MovieVm
            {
                Details = _mapper.Map<MovieDto>(result)
            };
        }
    }
}
