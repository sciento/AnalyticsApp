using System;
using System.Linq;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using AnalyticsServer.Models;
using AnalyticsServer.Interfaces;
using AnalyticsServer.Services;
using System.Diagnostics;
using System.Collections.Generic;
using System.Net;

namespace AnalyticsServer.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class UsersService : IUsersService
    {
        private AnalyticsEntities ae = new AnalyticsEntities();

        [WebInvoke(Method = "GET", UriTemplate = "/", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> Get()
        {
            RequestUser rs = new RequestUser();
            Response<Users> response = new Response<Users>();
            response.Items = new List<Users>();
            response.Items.Add(ae.Users.First(u => u.Id == rs.Id));
            return response;

        }
        [WebInvoke(Method = "DELETE", UriTemplate = "/{id}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> Remove(string id)
        {
            throw new NotImplementedException();
        }

        [WebInvoke(Method = "POST", UriTemplate = "/", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> Save()
        {
            throw new NotImplementedException();
        }

        [WebInvoke(Method = "PUT", UriTemplate = "/{id}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> Update(string id)
        {
            throw new NotImplementedException();
        }



    }
}