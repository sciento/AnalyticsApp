using AnalyticsLibrary.Helpers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http.Filters;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace AnalysticsLibrary.Authorization
{
    public static class RequestHeader
    {
        public static void AddAuthorizationHeader()
        {
            HttpCookie authCookie = HttpContext.Current.Request.Cookies[FormsAuthentication.FormsCookieName];
            Debug.WriteLine(authCookie);
            if (authCookie != null)
            {

                FormsAuthenticationTicket authTicket = FormsAuthentication.Decrypt(authCookie.Value);
                Debug.WriteLine(authTicket.Name);
                Debug.WriteLine(authTicket.UserData);
                JavaScriptSerializer serializer = new JavaScriptSerializer();
                CustomPrincipalSerializeModel cookieData = serializer.Deserialize<CustomPrincipalSerializeModel>(authTicket.UserData);


                WebOperationContext.Current.OutgoingRequest.Headers.Add("authorization", Crypt.Encrypt(cookieData.Username+":"+cookieData.Secret));
            }

        }

    }
}
