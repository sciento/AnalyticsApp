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
        private AnalyticsEntities ae = new AnalyticsEntities();
        [WebInvoke(Method = "GET", UriTemplate = "/{id}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Sites> GetAll(string id)
        {
            Guid requestId = new Guid(id);
            Response<Sites> sites = new Response<Sites>();
            RequestUser rs = new RequestUser();

            if (rs.Id == requestId)
            {
                sites.Items = ae.Sites.Where(s => s.UserId == requestId).ToList();
            }
            else
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Unauthorized;
                return null;
            }
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
            Guid requestId = new Guid(id);
            Guid requestPid = new Guid(pid);
            Response<Sites> sites = new Response<Sites>();
            RequestUser rs = new RequestUser();

            if (rs.Id == requestId)
            {
                sites.Items = ae.Sites.Where(s => s.UserId == requestId && s.Id == requestPid).ToList();
            }
            else
            {
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Unauthorized;
            }
            return sites;
        }

    }
}