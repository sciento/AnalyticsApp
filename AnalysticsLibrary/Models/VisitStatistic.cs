﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsLibrary.Models
{
    [Serializable]
    public class VisitStatistic
    {
        public VisitStatistic(Site site, double averageVisitTime, int visits)
        {
            Site = site;
            AverageVisitTime = averageVisitTime;
            Visits = visits;
        }

        [JsonProperty("site")]
        public Site Site { get; private set; }

        [JsonProperty("averageVisitTime")]
        public double AverageVisitTime { get; private set; }

        [JsonProperty("visits")]
        public int Visits { get; private set; }
    }
}
