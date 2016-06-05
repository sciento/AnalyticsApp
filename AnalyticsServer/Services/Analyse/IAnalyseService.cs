using AnalyticsServer.Models;
using System.Collections.Generic;
using System.ServiceModel;

namespace AnalyticsServer.Interfaces
{
    [ServiceContract]
    public interface IAnalyseSerivce
    {
        [OperationContract]
        string GetMost(string uid, string pid);

        [OperationContract]
        string GetMostByDate(string uid, string pid, string date);

        [OperationContract]
        string GetMostByWeek(string uid, string pid, string week);

        [OperationContract]
        string GetVisitsTimeAll(string uid, string pid);
        [OperationContract]
        string GetVisitsTimeByDay(string uid, string pid, string date);
        [OperationContract]
        string GetVisitsTimeByWeek(string uid, string pid, string week);
        [OperationContract]
        string GetVisitsByBrowser(string uid, string pid);
        [OperationContract]
        string GetVisitsByOs(string uid, string pid);
        [OperationContract]
        string GetVisitsByCountry(string uid, string pid);
        [OperationContract]
        string GetVisitsByReferral(string uid, string pid);

    }
}