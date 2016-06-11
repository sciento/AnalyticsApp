using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using AnalyticsServer.Models;
using System.Web;
using System.ServiceModel.Web;
using AnalyticsServer.Services;
using AnalyticsLibrary.Models;

namespace AnalyticsServer.Interfaces
{
    [ServiceContract]
    public interface IUsersService
    {
        [Auth]
        [OperationContract]
        Response<Users> Save();

        [Auth]
        [OperationContract]
        Response<Users> Get();

        [Auth]
        [OperationContract]
        Response<Users> Remove(string id);

        [Auth]
        [OperationContract]
        Response<Users> Update(string id);

        
    }
}