using AnalysticsLibrary.Authorization;
using AnalysticsLibrary.Helpers;
using AnalysticsLibrary.Models;
using AnalysticsLibrary.Users;
using AnalyticsApp.Models;
using AnalyticsApp.UsersReference;
using AnalyticsLibrary.Helpers;
using AnalyticsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.ServiceModel;
using System.Web;
using System.Web.Http;

namespace AnalyticsApp.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {

        private UsersServiceClient userService = new UsersServiceClient();
        /// <summary>
        /// Get Userdetails
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public IHttpActionResult GetUserDetails()
        {
            Response<Users> userDetailResponse = new Response<Users>();
            userDetailResponse.Error = new Error();
            using (new OperationContextScope(userService.InnerChannel))
            {
                RequestHeader.AddAuthorizationHeader();
                try
                {
                    userDetailResponse.Items = userService.Get().Items;
                }
                catch (CommunicationException e)
                {
                    userDetailResponse.Error.SetError(e.InnerException.Message);

                }
            }

            return Json(userDetailResponse);
        }

        [HttpPost]
        [Route("")]
        public IHttpActionResult Registration(Request<Registration> register)
        {
            Response<Users> response = new Response<Users>();
            response.Error = new Error();
            using (new OperationContextScope(userService.InnerChannel))
            {
                try
                {
                    RequestHeader.AddAuthorizationHeader();

                    if (register.Data.ValidateRegistraion() != null)
                    {
                        bool validated = true;
                        // TODO Not more than one Request per Channel Possible.
                        //if (!userService.CheckEmail(register.Data.Email))
                        //{
                        //    response.Error.SetError("E-Mail already in use.");
                        //    validated = false;
                        //    return Json(response);
                        //}

                        //if ()
                        //{
                        //    response.Error.SetError("Username already in use.");
                        //    validated = false;
                        //    return Json(response);
                        //}
                        Debug.WriteLine(userService.CheckUsernameAsync(register.Data.Username));
                        register.Data.Password = Crypt.EncodeHash(register.Data.Username, register.Data.Password);

                       return Json(userService.Save(register.Data));  

                    }
                    else
                        response.Error.SetError("8888 - User Registration Fail");
                    
                }
                catch (CommunicationException e)
                {
                    response.Error.SetError(e.InnerException.Message);
                }
            }

            return Json(response);
        }
    }
}
