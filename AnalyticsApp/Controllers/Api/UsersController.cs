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
using System.ServiceModel;
using System.Web;
using System.Web.Http;

namespace AnalyticsApp.Controllers
{
    [RoutePrefix("api/users")]
    public class UsersController : ApiController
    {

        private UsersReference.UsersServiceClient userService = new UsersReference.UsersServiceClient();
        /// <summary>
        /// Get Userdetails as JSON
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("")]
        public IHttpActionResult getUserDetails()
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
    }
}
