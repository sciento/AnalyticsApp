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
        Response<Users> Save();

        [OperationContract]
        Response<Users> Get(string id);

        [OperationContract]
        Response<Users> Remove(string id);

        [OperationContract]
        Response<Users> Update(string id);

        [OperationContract]
        Response<Users> SaveSite(string id);

        [OperationContract]
        Response<Users> GetUserSites(string id);

        [OperationContract]
        Response<Users> GetUserSite(string id, string pid);

        [OperationContract]
        Response<Users> UpdateUserSite(string id, string pid);

        [OperationContract]
        Response<Users> RemoveUserSite(string id, string pid);
    }
}