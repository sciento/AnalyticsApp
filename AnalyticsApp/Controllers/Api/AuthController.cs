using AnalysticsLibrary.Authorization;
using AnalysticsLibrary.Helpers;
using AnalysticsLibrary.Models;
using AnalyticsApp.Models;
using AnalyticsApp.UsersReference;
using AnalyticsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Principal;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Threading;
using System.Web;
using System.Web.Http;
using System.Web.Script.Serialization;
using System.Web.Security;

namespace AnalyticsApp.Controllers
{
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {
        private AuthReference.AuthServiceClient authService = new AuthReference.AuthServiceClient();

        /// <summary>
        /// Check Login Action
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public IHttpActionResult AuthRequest(AuthRequest authRequest)
        {
            Response<Users> authResponse = new Response<Users>();
            authResponse.Error = new Error();
            using (new OperationContextScope(authService.InnerChannel))
            {
                try
                {
                    RequestHeader.AddAuthorizationHeader();
                    if (authService.Auth(authRequest)) {
                        SetAuthCookie(authRequest);
                        return Json(authResponse);
                    } else
                    {
                        authResponse.Error.SetError("999 - LoginFail");
                    }
                }
                catch (CommunicationException e)
                {
                    authResponse.Error.SetError(e.InnerException.Message);
                }
            }
            return Json(authResponse);

        }


        [HttpGet]
        [Authorize]
        [Route("")]
        public IHttpActionResult GetAuth()
        {

            return Json(HttpContext.Current.User.Identity.Name);
        }

        private void SetAuthCookie(AuthRequest authRequest)
        {
            CustomPrincipalSerializeModel serializeModel = new CustomPrincipalSerializeModel();
            serializeModel.Username = authRequest.Username;
            serializeModel.Secret = authRequest.Secret;

            JavaScriptSerializer serializer = new JavaScriptSerializer();
            string userData = serializer.Serialize(serializeModel);
            FormsAuthenticationTicket authTicket = new FormsAuthenticationTicket(
              1,
              authRequest.Username,
              DateTime.Now,
              DateTime.Now.AddMinutes(15),
              false,
              userData);

            string encTicket = FormsAuthentication.Encrypt(authTicket);
            HttpCookie faCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encTicket);
            HttpContext.Current.Response.Cookies.Add(faCookie);
        }


    }
}
