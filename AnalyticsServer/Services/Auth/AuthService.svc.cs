using AnalyticsServer.Interfaces;
using System.ServiceModel.Activation;
using AnalysticsLibrary.Models;
using AnalyticsServer.Models;
using System.Linq;
using System.Diagnostics;
using System.Web;

namespace AnalyticsServer.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class AuthService : IAuthService
    {
        private AnalyticsEntities ae = new AnalyticsEntities();

        public bool Auth(AuthRequest auth)
        {
            Debug.WriteLine(HttpContext.Current.Request.Headers.ToString());


            Users checkUser = ae.Users
                .Where(u => ((u.Username == auth.Username) || (u.Email == auth.Username))  && u.Password == auth.Secret)
                .SingleOrDefault();

            if (checkUser != null)
                return true;

            return false;
        }


    }
}