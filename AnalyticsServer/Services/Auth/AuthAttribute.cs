using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnalyticsServer.Services { 
    public class Auth : Attribute
    {
        private string _access;
        public Auth(string access)
        {
            _access = access;
        }

        public string GetLevel()
        {
            return _access;
        }
    }
}