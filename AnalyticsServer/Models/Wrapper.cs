using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnalyticsServer.Models
{
    public class Wrapper
    {
        public Error Error { get; set; }
        public dynamic items { get; set; }
    }
}