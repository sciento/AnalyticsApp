using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AnalyticsServer.Models;
using AnalyticsServer.Interfaces;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using System.ServiceModel;

namespace AnalyticsServer.Services
{
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class VisitsService : IVisitsService
    {

        [WebInvoke(Method = "GET", UriTemplate = "/{uid}", ResponseFormat = WebMessageFormat.Json)]
        public string GetAllVisits(string uid)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/{uid}/{pid}", ResponseFormat = WebMessageFormat.Json)]
        public string GetPageVisits(string uid, string pid)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/{uid}/{pid}/date/{date}", ResponseFormat = WebMessageFormat.Json)]
        public string GetPageVisitsByDate(string uid, string pid, string date)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/{uid}/{pid}/week/{week}", ResponseFormat = WebMessageFormat.Json)]
        public string GetPageVisitsByWeek(string uid, string pid, string week)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "POST", UriTemplate = "/{uid}/{pid}", ResponseFormat = WebMessageFormat.Json)]
        public string SaveVisit(string uid, string pid)
        {
            throw new NotImplementedException();
        }
    }
}