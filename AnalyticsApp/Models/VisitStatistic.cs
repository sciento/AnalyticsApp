using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace AnalyticsApp.Models
{
    [DataContract]
    public class VisitStatistic
    {
        public VisitStatistic(Site site, double averageVisitTime, int visits)
        {
            Site = site;
            AverageVisitTime = averageVisitTime;
            Visits = visits;
        }

        [DataMember(Name = "site")]
        public Site Site { get; private set; }

        [DataMember(Name = "avg_visit_time")]
        public double AverageVisitTime { get; private set; }

        [DataMember(Name = "visits")]
        public int Visits { get; private set; }
    }
}
