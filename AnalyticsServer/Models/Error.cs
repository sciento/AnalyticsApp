using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnalyticsServer.Models
{
    public class Error
    {
        public int ErrorId { get; set; }
        public string Name { get; set; }
        public string Message { get; set; }  
    }
}