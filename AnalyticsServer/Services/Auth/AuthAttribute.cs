using AnalyticsLibrary.Helpers;
using AnalyticsServer.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Security.Principal;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;
using System.ServiceModel.Web;
using System.Text;
using System.Threading;
using System.Web;

namespace AnalyticsServer.Services
{
    public class AuthAttribute : Attribute, IOperationBehavior, IParameterInspector
    {
        AnalyticsEntities db = new AnalyticsEntities();

        public void ApplyDispatchBehavior(OperationDescription operationDescription,
            DispatchOperation dispatchOperation)
        {
            dispatchOperation.ParameterInspectors.Add(this);
        }

        public void AfterCall(string operationName, object[] outputs, object returnValue, object correlationState)
        {
        }

        public bool ValidateLogin(string username, string passwordHash)
        {
            return db.Users.Select(u => u.Username == username && u.Password == passwordHash).FirstOrDefault();

        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            string AuthHeader = HttpContext.Current.Request.Headers["authorization"];
            Debug.WriteLine(AuthHeader);

            if (AuthHeader != null)
            {
                AuthHeader = Crypt.Decrypt(AuthHeader);
                // Username:Secret
                string[] data = AuthHeader.Split(':');

                if ((data[0] != null) && (data[1] != null) && ValidateLogin(data[0], data[1]))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(data[0]), new string[0]);
                    return null;
                }
            }

            WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Unauthorized;
            throw new WebFaultException<string>("Unauthorized", HttpStatusCode.Unauthorized);
        }

        private string parseAuthorizationHeader(IncomingWebRequestContext request)
        {
            string rtnString = null;
            string authHeader = request.Headers["Authorization"];
            if (authHeader != null)
            {
                var authStr = authHeader.Trim();
                if (authStr.IndexOf("Basic", 0) == 0)
                {
                    string encodedCredentials = authStr.Substring(6);
                    byte[] decodedBytes = Convert.FromBase64String(encodedCredentials);
                    rtnString = new ASCIIEncoding().GetString(decodedBytes);
                }
            }
            return rtnString;
        }

        public void AddBindingParameters(OperationDescription operationDescription, System.ServiceModel.Channels.BindingParameterCollection bindingParameters)
        {
        }

        public void ApplyClientBehavior(OperationDescription operationDescription, ClientOperation clientOperation)
        {
        }

        public void Validate(OperationDescription operationDescription)
        {
        }

    }
}