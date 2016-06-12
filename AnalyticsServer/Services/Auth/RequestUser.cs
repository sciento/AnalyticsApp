using AnalyticsLibrary.Helpers;
using AnalyticsServer.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace AnalyticsServer.Services
{
    public class RequestUser
    {
        private AnalyticsEntities ae = new AnalyticsEntities();
        public string Username { get; set; }
        public string Email { get; set; } 
        public Guid Id { get; set; }
        public RequestUser()
        {
            string AuthHeader = HttpContext.Current.Request.Headers["authorization"];
            if (AuthHeader != null)
            {
                // Get Header Data
                AuthHeader = Crypt.Decrypt(AuthHeader);
                string[] pairs = AuthHeader.Split(':');
                string username = pairs[0];
                string hash = pairs[1];

                Users requestUser = ae.Users.First(u => u.Username == username && u.Password == hash);
                Id = requestUser.Id;
                Username = requestUser.Username;
                Email = requestUser.Email;

            }
        }
    }
}