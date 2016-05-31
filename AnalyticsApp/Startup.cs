using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AnalyticsApp.Startup))]
namespace AnalyticsApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
