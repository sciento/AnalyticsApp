using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AnalysticsLibrary.Authorization
{
    interface ICustomPrincipal : IPrincipal
    {
        string Username { get; set; }
        string Secret { get; set; }
        string Id { get; set; }

    }
}
