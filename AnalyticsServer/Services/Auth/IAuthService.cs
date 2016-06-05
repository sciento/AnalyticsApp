using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using AnalyticsServer.Models;
using System.Web;

namespace AnalyticsServer.Interfaces
{
    [ServiceContract]
    public interface IAuthService
    {
        
        [OperationContract]
        string GetScript(string id);



    }
}