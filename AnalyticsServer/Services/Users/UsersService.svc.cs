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
using AnalyticsLibrary.Models;

namespace AnalyticsServer.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class UsersService : IUsersService
    {
        private AnalyticsEntities ae = new AnalyticsEntities();

        public Response<Users> Get()
        {
            RequestUser rs = new RequestUser();
            Response<Users> response = new Response<Users>();
            response.Items = new List<Users> { ae.Users.First(u => u.Id == rs.Id) };
            return response;

        }
        public Response<Users> Remove(string id)
        {
            throw new NotImplementedException();
        }

        public Response<Users> Save()
        {
            throw new NotImplementedException();
        }

        public Response<Users> Update(string id)
        {
            throw new NotImplementedException();
        }



    }
}