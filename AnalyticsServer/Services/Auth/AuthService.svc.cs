using AnalyticsServer.Interfaces;
using System.ServiceModel.Activation;
using AnalysticsLibrary.Models;

namespace AnalyticsServer.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class AuthService : IAuthService
    {
        public void Auth(AuthRequest auth)
        {
           // WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.OK;

            Authorize authorize = new Authorize(auth.Username, auth.Secret);
        }


    }
}