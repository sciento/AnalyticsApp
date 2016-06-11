using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsApp.Models
{
    [DataContract]
    public class CountryStatistic
    {
        public CountryStatistic(Site site, string country, int visits)
        {
            Site = site;
            Country = country;
            Visits = visits;
        }

        [DataMember(Name = "site")]
        public Site Site { get; private set; }

        [DataMember(Name = "country")]
        public string Country { get; private set; }

        [DataMember(Name = "visits")]
        public int Visits { get; private set; }
    }
}
