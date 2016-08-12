using AnalysticsLibrary.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsLibrary.Models
{
    [Serializable]
    public class Site
    {
        public Site(Guid id, string title, Uri link, Owner owner)
        {
            Id = id;
            Title = title;
            Link = link;
            Owner = owner;
        }

        [JsonProperty("id")]
        public Guid Id { get; private set; }

        [JsonProperty("title")]
        public string Title { get; private set; }

        [JsonProperty("link")]
        public Uri Link { get; private set; }

        [JsonProperty("owner")]
        public Owner Owner { get; private set; }
    }
}
