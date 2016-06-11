using AnalyticsServer.Models;
using AnalyticsServer.Services.Auth;
using System;
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

        public void AfterCall(string operationName, object[] outputs,
                              object returnValue, object correlationState)
        {
        }

        public bool ValidateLogin(string username, string passwordHash)
        {
            return db.Users.Select(u => u.Username == username && u.Password == passwordHash).FirstOrDefault();

        }

        public object BeforeCall(string operationName, object[] inputs)
        {
            HttpCookie AuthCookie = HttpContext.Current.Request.Cookies["AuthCookie"];

            if (AuthCookie != null)
            {
                int j;
                AuthCookie.Value = Crypt.Decrypt(AuthCookie.Value);
                Random rnd = new Random();
                string[] pairs = AuthCookie.Value.Split('&');
                string username = pairs[0].Split('=')[1];
                string passwordHash = Crypt.Decrypt(pairs[1].Split('=')[1]);

                if (Int32.TryParse(pairs[2].Split('=')[1], out j))
                {
                    HttpCookie authCookie = new HttpCookie("AuthCookie");
                    authCookie["user"] = username;
                    authCookie["token"] = Crypt.Encrypt(passwordHash);
                    authCookie["nonce"] = rnd.Next(1000, 10000).ToString();
                    authCookie.Expires = DateTime.Now.AddDays(1d);
                    authCookie.Value = Crypt.Encrypt(authCookie.Value);
                    HttpContext.Current.Response.Cookies.Add(authCookie);


                }
                    

                if ((username != null) && (passwordHash != null) && ValidateLogin(username, passwordHash))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), new string[0]);
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