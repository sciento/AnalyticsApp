using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnalyticsServer.Models
{
    public class Site
    {
        public Guid SiteId { get; set; }
        public User Owner { get; set; }
        public string Url { get; set; }  
    }
}