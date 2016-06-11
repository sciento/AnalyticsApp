using AnalyticsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnalyticsApp.Controllers
{
    [RoutePrefix("api/visits")]
    public class VisitsController : ApiController
    {
        /// <summary>
        /// TODO this method returns just example data
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="siteId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{userId}/{siteId}")]
        public List<VisitStatistic> getByUserId(string userId, string siteId)
        {
            return  new List<VisitStatistic>
            {
                new VisitStatistic(
                    new Site(1, "Example", new Uri("http://www.example.com"),
                    new User(1, "Homer J.")),
                    230,
                    1337)
            };

           // return Json(new { items = items/*, error = new { error_id = 1, message = "error message" }*/ });
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{userId}")]
        public List<VisitStatistic> getAllByUserId(string userId)
        {
            return new List<VisitStatistic>
            {
                new VisitStatistic(
                    new Site(1, "Example", new Uri("http://www.example.com"),
                    new User(1, "Homer J.")),
                    230,
                    1337),
                new VisitStatistic(
                    new Site(2, "Test", new Uri("http://www.test.com"),
                    new User(1, "Homer J.")),
                    123,
                    1028),
                new VisitStatistic(
                    new Site(3, "Example 2", new Uri("http://www.example2.com"),
                    new User(1, "Homer J.")),
                    759,
                    12480),
                new VisitStatistic(
                    new Site(4, "Lorem Ipsum", new Uri("http://www.loremipsum.com"),
                    new User(1, "Homer J.")),
                    197,
                    496)
            };

           // return Json(new { items = items });
        }
    }
}
