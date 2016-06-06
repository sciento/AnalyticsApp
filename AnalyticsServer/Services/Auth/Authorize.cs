using AnalyticsServer.Models;
using AnalyticsServer.Services.Auth;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Security.Cryptography;
using System.ServiceModel.Web;
using System.Text;
using System.Web;

namespace AnalyticsServer.Services
{
    public class Authorize
    {
        AnalyticsEntities db = new AnalyticsEntities();
        private string _passwordHash = null;
        private string _username;
        private string _password;

        public Authorize(string username, string password)
        {
            _username = username;
            _password = password;

            Login();
        }
        public void Login()
        {
            if (CheckLogin())
                SetCookie();
            else
                WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.Unauthorized;

        }

        public void SetCookie()
        {
            Random rnd = new Random();
            HttpCookie authCookie = new HttpCookie("AuthCookie");
            authCookie["user"] = _username;
            authCookie["token"] = Crypt.Encrypt(_passwordHash);
            authCookie["nonce"] = rnd.Next(1000,10000).ToString();
            authCookie.Expires = DateTime.Now.AddDays(1d);
            authCookie.Value = Crypt.Encrypt(authCookie.Value);
            HttpContext.Current.Response.Cookies.Add(authCookie);
            WebOperationContext.Current.OutgoingResponse.StatusCode = HttpStatusCode.OK;
        }

        public bool CheckLogin()
        {
            _passwordHash = Crypt.EncodeHash(_username, _password);
            return db.Users.Select(u => u.Username == _username && u.Password == _passwordHash).FirstOrDefault();
        }



    }

}