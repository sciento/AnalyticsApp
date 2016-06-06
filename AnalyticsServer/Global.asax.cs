using System;
using System.ServiceModel.Activation;
using System.Web.Routing;
using AnalyticsServer.Services;
using System.Diagnostics;
using System.ServiceModel.Web;
using System.Collections.Generic;
using System.Reflection;
using System.Linq;
using System.Security.Permissions;
using System.Web;
using System.Web.Security;
using System.Security.Principal;
using System.Threading;
using System.Net;

namespace AnalyticsServer
{
    public class Global : HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {

            Debug.WriteLine("Application Start");
            RouteTable.Routes.Add(new ServiceRoute("analyses", new WebServiceHostFactory(), typeof(AnalyseSerivce)));
            RouteTable.Routes.Add(new ServiceRoute("users", new WebServiceHostFactory(), typeof(UsersService)));
            RouteTable.Routes.Add(new ServiceRoute("visits", new WebServiceHostFactory(), typeof(VisitsService)));
            RouteTable.Routes.Add(new ServiceRoute("embed", new WebServiceHostFactory(), typeof(EmbedService)));
            RouteTable.Routes.Add(new ServiceRoute("auth", new WebServiceHostFactory(), typeof(AuthService)));

        }


        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Debug.WriteLine("Beginn Request");
            GenericIdentity identity = new GenericIdentity("M.Brown");
            System.Threading.Thread.CurrentPrincipal =
                 new GenericPrincipal(
                     identity, new string[] { "Administrators" }
                 );
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            HttpCookieCollection headers = Context.Request.Cookies;
            foreach (string cookie in headers)
            {
                Debug.WriteLine(cookie);


            }

            if (Request.Cookies["UserSettings"] != null)
            {
                string userSettings;
                if (Request.Cookies["UserSettings"]["Font"] != null)
                {
                    userSettings = Request.Cookies["UserSettings"]["Font"];
                    Debug.WriteLine(userSettings);
                }
            }




        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Debug.WriteLine("Application Error");
        }


        protected void Application_End(object sender, EventArgs e)
        {
            Debug.WriteLine("Application End");

        }
    }
}