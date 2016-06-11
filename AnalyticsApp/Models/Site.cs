using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsApp.Models
{
    [DataContract]
    public class Site
    {
        public Site(int id, string title, Uri link, User owner)
        {
            Id = id;
            Title = title;
            Link = link;
            Owner = owner;
        }

        [DataMember(Name = "site_id")]
        public int Id { get; private set; }

        [DataMember(Name = "title")]
        public string Title { get; private set; }

        [DataMember(Name = "link")]
        public Uri Link { get; private set; }

        [DataMember(Name = "owner")]
        public User Owner { get; private set; }
    }
}
