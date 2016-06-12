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
        private Random random = new Random();

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="siteId"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("")]
        public string AuthRequest(AuthRequest auth)
        {

            Debug.WriteLine(auth);
            
            return "blub";
        }
    }
}
