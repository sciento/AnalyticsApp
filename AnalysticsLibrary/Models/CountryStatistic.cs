﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsLibrary.Models
{
    [Serializable]
    public class CountryStatistic
    {
        public CountryStatistic(Site site, string country, int visits)
        {
            Site = site;
            Country = country;
            Visits = visits;
        }

        [JsonProperty("site")]
        public Site Site { get; private set; }

        [JsonProperty("country")]
        public string Country { get; private set; }

        [JsonProperty("visits")]
        public int Visits { get; private set; }
    }
}
