﻿using AnalysticsLibrary.Models;
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
        public IHttpActionResult getByUserId(string userId, string siteId)
        {
            return Json(new Response<CountryStatistic>
            {
                Items = new List<CountryStatistic>
                {
                    new CountryStatistic(
                        new Site(Guid.NewGuid(), "Example", new Uri("http://www.example.com"), new Owner(Guid.NewGuid(), "Homer J.")),
                        "Australia",
                        random.Next(100000)),
                    new CountryStatistic(
                        new Site(Guid.NewGuid(), "Example", new Uri("http://www.example.com"), new Owner(Guid.NewGuid(), "Homer J.")),
                        "Austria",
                        random.Next(100000)),
                    new CountryStatistic(
                        new Site(Guid.NewGuid(), "Example", new Uri("http://www.example.com"), new Owner(Guid.NewGuid(), "Homer J.")),
                        "Germany",
                        random.Next(100000)),
                    new CountryStatistic(
                        new Site(Guid.NewGuid(), "Example", new Uri("http://www.example.com"), new Owner(Guid.NewGuid(), "Homer J.")),
                        "Italy",
                        random.Next(100000)),
                    new CountryStatistic(
                        new Site(Guid.NewGuid(), "Example", new Uri("http://www.example.com"), new Owner(Guid.NewGuid(), "Homer J.")),
                        "USA",
                        random.Next(100000))
                }
            });
        }
    }
}
