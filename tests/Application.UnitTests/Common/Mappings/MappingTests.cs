﻿using AutoMapper;
using movie_db_app.Application.Common.Mappings;
using movie_db_app.Application.Movies.Queries.DiscoverMovies;
using movie_db_app.Application.Movies.Queries.GetMovieDetails;
using movie_db_app.Domain.Entities;
using NUnit.Framework;
using System;

namespace movie_db_app.Application.UnitTests.Common.Mappings
{
    public class MappingTests
    {
        private readonly IConfigurationProvider _configuration;
        private readonly IMapper _mapper;

        public MappingTests()
        {
            _configuration = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            });

            _mapper = _configuration.CreateMapper();
        }

        [Test]
        public void ShouldHaveValidConfiguration()
        {
            _configuration.AssertConfigurationIsValid();
        }
        
        [Test]
        [TestCase(typeof(MovieList), typeof(MovieListDto))]
        [TestCase(typeof(Movie), typeof(MovieDto))]
        public void ShouldSupportMappingFromSourceToDestination(Type source, Type destination)
        {
            var instance = Activator.CreateInstance(source);

            _mapper.Map(instance, source, destination);
        }
    }
}
