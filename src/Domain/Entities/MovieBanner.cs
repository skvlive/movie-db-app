using movie_db_app.Domain.Common;
using movie_db_app.Domain.Enums;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using System.Configuration;

namespace movie_db_app.Domain.Entities
{
    [JsonObject(MemberSerialization.OptIn)]
    public class MovieBanner
    {
        [JsonProperty("popularity")]
        public float Popularity { get; set; }

        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }

        [JsonProperty("video")]
        public bool Video { get; set; }

        [JsonProperty("poster_path")]
        public string PosterPath { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("adult")]
        public bool Adult { get; set; }

        [JsonProperty("backdrop_path")]
        public string BackdropPath { get; set; }

        [JsonProperty("original_language")]
        public string OriginalLanguage { get; set; }

        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; }

        [JsonProperty("genre_ids")]
        public IList<int> GenreIds { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("vote_average")]
        public float VoteAverage { get; set; }

        [JsonProperty("overview")]
        public string Overview { get; set; }
        
        [JsonProperty("release_date")]
        public DateTime ReleaseDate { get; set; }

        public string FormattedDate
        {
            get
            {
                return ReleaseDate.ToString("D");
            }
        }
        public string ImagePath
        {
            get 
            {
                return ConfigurationManager.AppSettings["imageUrl"] + PosterPath;
            }
        }
    }
}