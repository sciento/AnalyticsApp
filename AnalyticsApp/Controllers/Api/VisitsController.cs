using AnalyticsApp.Models;
using AnalyticsLibrary.Models;
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
        public IHttpActionResult getByUserId(string userId, string siteId)
        {
            return Json(new Response<VisitStatistic>
            {
                Items = new List<VisitStatistic>
                {
                    new VisitStatistic(
                        new Site(Guid.NewGuid(), "Example", new Uri("http://www.example.com"),
                        new User(Guid.NewGuid(), "Homer J.")),
                        230,
                        1337)
                }
            });
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{userId}")]
        public IHttpActionResult getAllByUserId(string userId)
        {
            return Json(new Response<VisitStatistic>
            {
                Items = new List<VisitStatistic>
                {
                    new VisitStatistic(
                        new Site(Guid.NewGuid(), "Example", new Uri("http://www.example.com"),
                        new User(Guid.NewGuid(), "Homer J.")),
                        230,
                        1337),
                    new VisitStatistic(
                        new Site(Guid.NewGuid(), "Test", new Uri("http://www.test.com"),
                        new User(Guid.NewGuid(), "Homer J.")),
                        123,
                        1028),
                    new VisitStatistic(
                        new Site(Guid.NewGuid(), "Example 2", new Uri("http://www.example2.com"),
                        new User(Guid.NewGuid(), "Homer J.")),
                        759,
                        12480),
                    new VisitStatistic(
                        new Site(Guid.NewGuid(), "Lorem Ipsum", new Uri("http://www.loremipsum.com"),
                        new User(Guid.NewGuid(), "Homer J.")),
                        197,
                        496)
                }
            });
        }
    }
}
