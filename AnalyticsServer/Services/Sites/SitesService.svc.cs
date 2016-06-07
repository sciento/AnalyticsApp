using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnalyticsServer.Models;
using AnalyticsServer.Interfaces;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.ServiceModel;
using System.Net;

namespace AnalyticsServer.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class SitesService : ISitesService
    {
        [WebInvoke(Method = "GET", UriTemplate = "/{id}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Sites> GetAll(string id)
        {

            Response<Sites> sites = new Response<Sites>();

            return sites;
        }

        [WebInvoke(Method = "DELETE", UriTemplate = "/{id}/{pid}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> Remove(string id, string pid)
        {
            throw new NotImplementedException();
        }

        [WebInvoke(Method = "POST", UriTemplate = "/", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> Save(string id)
        {
            throw new NotImplementedException();
        }

        [WebInvoke(Method = "PUT", UriTemplate = "/{id}/{pid}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Sites> Update(string id, string pid)
        {
            throw new NotImplementedException();
        }

        [WebInvoke(Method = "GET", UriTemplate = "/{id}/{pid}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Sites> Get(string id, string pid)
        {

            Response<Sites> sites = new Response<Sites>();

            return sites;
        }

    }
}