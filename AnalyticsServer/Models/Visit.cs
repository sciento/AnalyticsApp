using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnalyticsServer.Models
{
    public class Visit
    {
        public Guid VisitId { get; set; }
        public Site Site { get; set; }
        public string Ip { get; set; }
        public string Browser { get; set; }
        public string PageUrl { get; set; }
        public DateTime CallTime { get; set; }
        public DateTime ExitTime { get; set; }
        public string Referer { get; set; }
        public string Os { get; set; }

    }
}