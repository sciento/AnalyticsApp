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
using AnalysticsLibrary.Users;

namespace AnalyticsServer.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class UsersService : IUsersService
    {
        private AnalyticsEntities ae = new AnalyticsEntities();

        public bool CheckEmail(string email)
        {
            Users checkEmail = ae.Users.Where(u => u.Email == email).First();
            if (checkEmail == null)
                return true;

            return false;
        }

        public bool CheckUsername(string username)
        {
            Users checkEmail = ae.Users.Where(u => u.Username == username).First();
            if (checkEmail == null)
                return true;

            return false;
        }

        public Response<Users> Get()
        {
            RequestUser rs = new RequestUser();
            Response<Users> response = new Response<Users>();
            response.Items = ae.Users.Where(u => u.Id == rs.Id);
            return response;

        }
        public Response<Users> Remove(string id)
        {
            throw new NotImplementedException();
        }

        public bool Save(Registration newUser)
        {
            Users user = new Users {
                Id = Guid.NewGuid(),
                Username = newUser.Username,
                Password = newUser.Password,
                Email = newUser.Email
            };
            try
            {
                ae.Users.Add(user);
                ae.SaveChanges();
                return true;
            }
            catch (Exception e)
            {

                Debug.WriteLine(e.Message);
                return false;
            }

        }

        public Response<Users> Update(string id)
        {
            throw new NotImplementedException();
        }



    }
}