using Microsoft.IdentityModel.Protocols;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using System.Web;
using System.Collections.Specialized;
using Microsoft.AspNetCore.WebUtilities;

namespace movie_db_app.Infrastructure.Services
{
    class RequestBuilder
    {
        // TODO : Settings should come with the interface dependancy
        string url = ConfigurationManager.AppSettings["movieDbUrl"];
        string apiKey = ConfigurationManager.AppSettings["apiKey"];
        Dictionary<string, string> parameters = new Dictionary<string, string>();

        public RequestBuilder TypeMovie()
        {
            url += "movie";
            return this;
        }

        public RequestBuilder Discover()
        {
            url += "discover/";
            return this;
        }

        public RequestBuilder WithId(string type,string id)
        {
            url += type + '/' + id;
            return this;
        }

        public RequestBuilder InLanguage(string language)
        {
            parameters.Add("language", language);
            return this;
        }

        public RequestBuilder WithRatingGTE(float rating)
        {
            parameters.Add("vote_average.gte", rating.ToString());
            return this;
        }

        public RequestBuilder SortBy(string field)
        {
            parameters.Add("sort_by", field);
            return this;
        }

        public RequestBuilder WithId(string type, int id)
        {
            url += type + '/' + id;
            return this;
        }

        public string Build()
        {
            parameters.Add("api_key", apiKey);
            return QueryHelpers.AddQueryString(url, parameters);
        }
    }
}
