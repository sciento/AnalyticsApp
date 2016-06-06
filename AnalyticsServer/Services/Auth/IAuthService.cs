using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using AnalyticsServer.Models;
using System.Web;
using AnalyticsServer.Services;

namespace AnalyticsServer.Interfaces
{
    [ServiceContract]
    public interface IAuthService
    {
        [OperationContract]
        void Auth(AuthRequest auth);



    }
}