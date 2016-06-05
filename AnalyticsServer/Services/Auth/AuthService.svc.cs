using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnalyticsServer.Models;
using AnalyticsServer.Interfaces;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.ServiceModel;
using System.Diagnostics;

namespace AnalyticsServer.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class AuthService : IAuthService
    {
        [Auth("public")]
        [WebInvoke(Method="GET", UriTemplate= "/{id}", ResponseFormat = WebMessageFormat.Json)]
        public string GetScript(string id)
        {

            Debug.WriteLine("test");
            return "Script: " + id;

        }

    }
}