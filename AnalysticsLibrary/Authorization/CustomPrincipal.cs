using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AnalysticsLibrary.Authorization
{
    public class CustomPrincipal : ICustomPrincipal
    {
        public IIdentity Identity { get; private set; }
        public CustomPrincipal(string username)
        {
            Identity = new GenericIdentity(username);
        }
        public string Secret { get;  set; }

        public string Username { get; set; }
        public string Id { get; set; }

        public bool IsInRole(string role){ return false; }
    }

    public class CustomPrincipalSerializeModel
    {
        public string Id { get; set; }
        public string Username { get; set; }
        public string Secret { get; set; }
    }
}
