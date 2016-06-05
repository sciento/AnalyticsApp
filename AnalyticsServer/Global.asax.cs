using System;
using System.ServiceModel.Activation;
using System.Web.Routing;
using AnalyticsServer.Services;
using System.Diagnostics;

namespace AnalyticsServer
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            Console.WriteLine("Application Start");
            Debug.WriteLine("test");
            RouteTable.Routes.Add(new ServiceRoute("analyses", new WebServiceHostFactory(), typeof(AnalyseSerivce)));
            RouteTable.Routes.Add(new ServiceRoute("users", new WebServiceHostFactory(), typeof(UsersService)));
            RouteTable.Routes.Add(new ServiceRoute("visits", new WebServiceHostFactory(), typeof(VisitsService)));
            RouteTable.Routes.Add(new ServiceRoute("embed", new WebServiceHostFactory(), typeof(EmbedService)));
        }


        protected void Session_Start(object sender, EventArgs e)
        {
            Console.WriteLine("Session Start");
        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            Console.WriteLine("Beginn Request");
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {
            Console.WriteLine("Authenticate Request");
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Console.WriteLine("Application Error");
        }

        protected void Session_End(object sender, EventArgs e)
        {
            Console.WriteLine("Session End");
        }

        protected void Application_End(object sender, EventArgs e)
        {
            Console.WriteLine("Application End");

        }
    }
}