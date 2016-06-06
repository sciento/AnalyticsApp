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
using System.Security.Permissions;
using System.Net;

namespace AnalyticsServer.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class AuthService : IAuthService
    {
        [WebInvoke(Method="POST", UriTemplate= "/", RequestFormat = WebMessageFormat.Json)]
        public void Auth(AuthRequest auth)
        {
           // WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.OK;

            Authorize authorize = new Authorize(auth.username, auth.password);
        }


    }
}