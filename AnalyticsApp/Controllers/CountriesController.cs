using AnalyticsApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnalyticsApp.Controllers
{
    [RoutePrefix("api/countries")]
    public class CountriesController : ApiController
    {
        private Random random = new Random();

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="siteId"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("{userId}/{siteId}")]
        public IHttpActionResult getByUserId(int userId, int siteId)
        {
            var items = new List<CountryStatistic>
            {
                new CountryStatistic(
                    new Site(1, "Example", new Uri("http://www.example.com"), new User(1, "Homer J.")),
                    "Australia",
                    random.Next(100000)),
                new CountryStatistic(
                    new Site(1, "Example", new Uri("http://www.example.com"), new User(1, "Homer J.")),
                    "Austria",
                    random.Next(100000)),
                new CountryStatistic(
                    new Site(1, "Example", new Uri("http://www.example.com"), new User(1, "Homer J.")),
                    "Germany",
                    random.Next(100000)),
                new CountryStatistic(
                    new Site(1, "Example", new Uri("http://www.example.com"), new User(1, "Homer J.")),
                    "Italy",
                    random.Next(100000)),
                new CountryStatistic(
                    new Site(1, "Example", new Uri("http://www.example.com"), new User(1, "Homer J.")),
                    "USA",
                    random.Next(100000))
            };

            return Json(new { items = items });
        }
    }
}
