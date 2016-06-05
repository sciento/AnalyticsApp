using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnalyticsServer.Models;
using AnalyticsServer.Interfaces;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;

namespace AnalyticsServer.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class UsersService : IUsersService
    {
        [WebInvoke(Method = "GET", UriTemplate = "/{id}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> Get(string id)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "DELETE", UriTemplate = "/{id}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> Remove(string id)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "DELETE", UriTemplate = "/sites/{id}/{pid}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> RemoveUserSite(string id, string pid)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "POST", UriTemplate = "/", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> Save()
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "POST", UriTemplate = "/sites/{id}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> SaveSite(string id)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "PUT", UriTemplate = "/{id}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> Update(string id)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "PUT", UriTemplate = "/sites/{id}/{pid}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> UpdateUserSite(string id, string pid)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/sites/{id}/{pid}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> GetUserSite(string id, string pid)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/sites/{id}", ResponseFormat = WebMessageFormat.Json)]
        public Response<Users> GetUserSites(string id)
        {
            throw new NotImplementedException();
        }
    }
}