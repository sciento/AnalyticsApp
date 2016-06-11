using Newtonsoft.Json;
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

      //  [DataMember(Name = "site")]
        [JsonProperty("site")]
        public Site Site { get; private set; }

        //  [DataMember(Name = "avg_visit_time")]
        [JsonProperty("avg_visit_time")]
        public double AverageVisitTime { get; private set; }

        // [DataMember(Name = "visits")]
        [JsonProperty("visits")]
        public int Visits { get; private set; }
    }
}
