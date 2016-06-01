using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using AnalyticsServer.Models;
using System.Web;

namespace AnalyticsServer.Interfaces
{
    [ServiceContract]
    public interface IServiceVisit
    {
        [OperationContract]
        String Get();

        [OperationContract]
        List<Visit> GetList();


    }
}