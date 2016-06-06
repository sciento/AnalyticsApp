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
    public interface ISitesService
    {
        [Auth]
        [OperationContract]
        Response<Users> Save(string id);

        [Auth]
        [OperationContract]
        Response<Sites> GetAll(string id);

        [Auth]
        [OperationContract]
        Response<Sites> Get(string id, string pid);

        [Auth]
        [OperationContract]
        Response<Sites> Update(string id, string pid);

        [Auth]
        [OperationContract]
        Response<Users> Remove(string id, string pid);



    }
}