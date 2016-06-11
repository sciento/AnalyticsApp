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
            HttpCookie AuthCookie = HttpContext.Current.Request.Cookies["AuthCookie"];
            if (AuthCookie != null)
            {
                // Get Cookie Data
                string[] pairs = AuthCookie.Value.Split('&');
                string username = pairs[0].Split('=')[1];
                string hash = Crypt.Decrypt(pairs[1].Split('=')[1]);

                Users requestUser = ae.Users.First(u => u.Username == username && u.Password == hash);
                Id = requestUser.Id;
                Username = requestUser.Username;
                Email = requestUser.Email;

            }
        }
    }
}