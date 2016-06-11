using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsApp.Models
{
    [DataContract]
    public class User
    {
        public User(int id, string displayName) : this(id, displayName, Enumerable.Empty<Site>())
        {

        }

        public User(int id, string displayName, IEnumerable<Site> sites)
        {
            Id = id;
            DisplayName = displayName;
            Sites = sites;
        }

        [DataMember(Name = "user_id")]
        public int Id { get; private set; }

        [DataMember(Name = "display_name")]
        public string DisplayName { get; private set; }

        [DataMember(Name = "sites")]
        public IEnumerable<Site> Sites { get; private set; }
    }
}
