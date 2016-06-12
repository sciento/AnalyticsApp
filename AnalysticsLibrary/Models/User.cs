using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsLibrary.Models
{
    [Serializable]
    public class User
    {
        public User(Guid id, string displayName) : this(id, displayName, Enumerable.Empty<Site>())
        {

        }

        public User(Guid id, string displayName, IEnumerable<Site> sites)
        {
            Id = id;
            DisplayName = displayName;
            Sites = sites;
        }

        [JsonProperty("user_id")]
        public Guid Id { get; private set; }

        [JsonProperty("display_name")]
        public string DisplayName { get; private set; }

        [JsonProperty("sites")]
        public IEnumerable<Site> Sites { get; private set; }
    }
}
