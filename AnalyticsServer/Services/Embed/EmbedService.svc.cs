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
    public class EmbedService : IEmbedService
    {
        [WebInvoke(Method="GET", UriTemplate= "/{id}", ResponseFormat = WebMessageFormat.Json)]
        public string GetScript(string id)
        {
            return "Script: " + id;

        }

    }
}