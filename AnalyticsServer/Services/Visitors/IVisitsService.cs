using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using AnalyticsServer.Models;
using System.Web;

namespace AnalyticsServer.Interfaces
{
    [ServiceContract]
    public interface IVisitsService
    {
        [OperationContract]
        string SaveVisit(string uid, string pid);
        [OperationContract]
        string GetAllVisits(string uid);
        [OperationContract]
        string GetPageVisits(string uid, string pid);
        [OperationContract]
        string GetPageVisitsByDate(string uid, string pid, string date);
        [OperationContract]
        string GetPageVisitsByWeek(string uid, string pid, string week);
    }
}