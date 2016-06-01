using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnalyticsServer.Models;
using AnalyticsServer.Interfaces;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;

namespace AnalyticsServer.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class VisitService : IVisitService
    {
        [WebInvoke(Method="GET", UriTemplate="find", ResponseFormat = WebMessageFormat.Json)]
        public string Get()
        {
            return "test";
            //new Visit {
             //   Browser = "Explorer",
            //    Ip = "127.0.0.1"
            //};
        }

        [WebInvoke]
        public List<Visit> GetList()
        {
            throw new NotImplementedException();
        }
    }
}