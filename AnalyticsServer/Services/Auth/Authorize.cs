using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;

namespace AnalyticsServer.Services
{
    public class Authorize
    {
        public List<string> list = new List<string>();
        public Authorize()
        {
            MethodInfo[] method = typeof(AuthService).GetMethods(BindingFlags.Instance);

            foreach (var attrib in method)
            {
                Attribute[] attributes = Attribute.GetCustomAttributes(attrib, typeof(Auth), true);
                foreach (Auth at in attributes)
                {
                    list.Add(at.GetLevel());
                }
                
            }
        }
    }
}