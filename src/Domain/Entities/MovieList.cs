using movie_db_app.Domain.Common;
using movie_db_app.Domain.Enums;
using System.Collections.Generic;
using System;
using movie_db_app.Domain.Entities;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace movie_db_app.Domain.Entities
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MovieList
    {
        public MovieList()
        {
            Items = new List<MovieBanner>();
        }

        [JsonProperty("page")]
        public int Page { get; set; }

        [JsonProperty("total_results")]
        public int TotalItems { get; set; }

        [JsonProperty("total_pages")]
        public int TotalPages { get; set; }

        [JsonProperty("results")]
        public IList<MovieBanner> Items { get; set; }
    }
}
