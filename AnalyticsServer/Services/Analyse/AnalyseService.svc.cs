using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnalyticsServer.Models;
using AnalyticsServer.Interfaces;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.ServiceModel;

namespace AnalyticsServer.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class AnalyseSerivce : IAnalyseSerivce
    {
        [WebInvoke(Method="GET", UriTemplate= "get/{test}", ResponseFormat = WebMessageFormat.Json)]
        public string Get(string test)
        {
            return "get" + test;

        }

    }
}