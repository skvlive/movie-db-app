using movie_db_app.Application.Common.Interfaces;
using System;

namespace movie_db_app.Infrastructure.Services
{
    public class DateTimeService : IDateTime
    {
        public DateTime Now => DateTime.Now;
    }
}
