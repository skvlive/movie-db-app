using movie_db_app.Domain.Common;
using movie_db_app.Domain.Enums;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

namespace movie_db_app.Domain.Entities
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Movie
    {
        [JsonProperty("belongs_to_collection")]
        public CollectionType BelongsToCollection { get; set; }

        [JsonProperty("budget")]
        public int Budget { get; set; }

        [JsonProperty("genres")]
        public IList<Genre> Genres { get; set; }

        [JsonProperty("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("imdb_id")]
        public string ImdbId { get; set; }

        [JsonProperty("production_companies")]
        public IList<ProductionCompany> ProductionCompanies { get; set; }

        [JsonProperty("production_countries")]
        public IList<ProductionCountry> ProductionCountries { get; set; }

        [JsonProperty("revenue")]
        public int Revenue { get; set; }

        [JsonProperty("runtime")]
        public int Runtime { get; set; }

        [JsonProperty("spoken_languages")]
        public IList<SpokenLanguage> SpokenLanguages { get; set; }

        [JsonProperty("status")]
        public Status Status { get; set; }

        [JsonProperty("tagline")]
        public string Tagline { get; set; }

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
                return System.Configuration.ConfigurationManager.AppSettings["imageUrl"] + PosterPath;
            }
        }

        public string BackgroundImagePath
        {
            get
            {
                return System.Configuration.ConfigurationManager.AppSettings["imageUrl"] + BackdropPath;
            }
        }
    }
}