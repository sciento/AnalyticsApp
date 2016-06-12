using AnalysticsLibrary.Models;
using AnalyticsApp.Models;
using AnalyticsLibrary.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnalyticsApp.Controllers
{
    [RoutePrefix("api/auth")]
    public class AuthController : ApiController
    {

        /// <summary>
        /// Check Login Action
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public bool AuthRequest(AuthRequest authRequest)
        {
            Response<AuthRequest> authResponse = new Response<AuthRequest>();
            Debug.WriteLine(authRequest.Username);
            Debug.WriteLine(authRequest.Secret);
            
            return false;
        }
    }
}
