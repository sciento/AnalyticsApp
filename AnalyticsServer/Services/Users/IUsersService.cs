using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using AnalyticsServer.Models;
using System.Web;
using System.ServiceModel.Web;

namespace AnalyticsServer.Interfaces
{
    [ServiceContract]
    public interface IUsersService
    {
        [OperationContract]
        String Root();

        [OperationContract]
        String Test();



    }
}