using movie_db_app.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace movie_db_app.Domain.Entities
{
    public class CollectionType
    {
        public int Id { get; set; }

        public string Name { get; set; }
    
        public string PosterPath { get; set; }
    
        public string BackdropPath { get; set; }
    }
}
