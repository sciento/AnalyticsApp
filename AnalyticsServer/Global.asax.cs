using System;
using System.ServiceModel.Activation;
using System.Web.Routing;
using AnalyticsServer.Services;

namespace AnalyticsServer
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.Add(new ServiceRoute("site", new WebServiceHostFactory(), typeof(SitesService)));
            RouteTable.Routes.Add(new ServiceRoute("analyse", new WebServiceHostFactory(), typeof(AnalyseSerivce)));
            RouteTable.Routes.Add(new ServiceRoute("user", new WebServiceHostFactory(), typeof(UsersService)));
            RouteTable.Routes.Add(new ServiceRoute("visit", new WebServiceHostFactory(), typeof(VisitorsService)));
            RouteTable.Routes.Add(new ServiceRoute("embed", new WebServiceHostFactory(), typeof(EmbedService)));
        }


        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}