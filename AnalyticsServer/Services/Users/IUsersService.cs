using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using AnalyticsServer.Models;
using System.Web;
using System.ServiceModel.Web;
using AnalyticsServer.Services;

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
        Response<Users> Get(string id);

        [Auth]
        [OperationContract]
        Response<Users> Remove(string id);

        [Auth]
        [OperationContract]
        Response<Users> Update(string id);

        [Auth]
        [OperationContract]
        Response<Users> SaveSite(string id);

        [Auth]
        [OperationContract]
        Response<Users> GetUserSites(string id);

        [Auth]
        [OperationContract]
        Response<Users> GetUserSite(string id, string pid);

        [Auth]
        [OperationContract]
        Response<Users> UpdateUserSite(string id, string pid);

        [Auth]
        [OperationContract]
        Response<Users> RemoveUserSite(string id, string pid);
    }
}