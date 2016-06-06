using AnalyticsServer.Models;
using AnalyticsServer.Services;
using System.Collections.Generic;
using System.ServiceModel;

namespace AnalyticsServer.Interfaces
{
    [ServiceContract]
    public interface IAnalyseSerivce
    {
        [Auth]
        [OperationContract]
        string GetMost(string uid, string pid);
        [Auth]
        [OperationContract]
        string GetMostByDate(string uid, string pid, string date);
        [Auth]
        [OperationContract]
        string GetMostByWeek(string uid, string pid, string week);
        [Auth]
        [OperationContract]
        string GetVisitsTimeAll(string uid, string pid);
        [Auth]
        [OperationContract]
        string GetVisitsTimeByDay(string uid, string pid, string date);
        [Auth]
        [OperationContract]
        string GetVisitsTimeByWeek(string uid, string pid, string week);
        [Auth]
        [OperationContract]
        string GetVisitsByBrowser(string uid, string pid);
        [Auth]
        [OperationContract]
        string GetVisitsByOs(string uid, string pid);
        [Auth]
        [OperationContract]
        string GetVisitsByCountry(string uid, string pid);
        [Auth]
        [OperationContract]
        string GetVisitsByReferral(string uid, string pid);

    }
}