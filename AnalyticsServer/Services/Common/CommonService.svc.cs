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
    public class CommonService : ICommonService
    {
        [WebInvoke(Method="GET", UriTemplate="", ResponseFormat = WebMessageFormat.Xml)]
        public string Root()
        {

            return "API Online";

        }

        [WebInvoke(Method = "GET", UriTemplate = "test", ResponseFormat = WebMessageFormat.Xml)]
        public string Test()
        {
            return "test";
        }
    }
}