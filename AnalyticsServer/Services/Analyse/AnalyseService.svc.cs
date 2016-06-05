using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Web;
using System.ServiceModel.Activation;
using AnalyticsServer.Interfaces;
using AnalyticsServer.Models;
using System.Collections;

namespace AnalyticsServer.Services
{
    [Serializable]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Required)]
    public class AnalyseSerivce : IAnalyseSerivce
    {
        private AnalyticsEntities AE = new AnalyticsEntities();
        
        public AnalyseSerivce()
        {
            AE.Configuration.ProxyCreationEnabled = false;

        }

        [WebInvoke(Method = "GET", UriTemplate = "/most/{uid}/{pid}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public string GetMost(string uid, string pid)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/most/{uid}/{pid}/date/{date}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public string GetMostByDate(string uid, string pid, string date)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/most/{uid}/{pid}/week/{week}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public string GetMostByWeek(string uid, string pid, string week)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/browser/{uid}/{pid}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public string GetVisitsByBrowser(string uid, string pid)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/country/{uid}/{pid}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public string GetVisitsByCountry(string uid, string pid)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/os/{uid}/{pid}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public string GetVisitsByOs(string uid, string pid)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/referral/{uid}/{pid}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public string GetVisitsByReferral(string uid, string pid)
        {
            throw new NotImplementedException();
        }

        [WebInvoke(Method = "GET", UriTemplate = "/time/{uid}/{pid}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public string GetVisitsTimeAll(string uid, string pid)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/time/{uid}/{pid}/date/{date}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public string GetVisitsTimeByDay(string uid, string pid, string date)
        {
            throw new NotImplementedException();
        }
        [WebInvoke(Method = "GET", UriTemplate = "/time/{uid}/{pid}/week/{week}", ResponseFormat = WebMessageFormat.Json, BodyStyle = WebMessageBodyStyle.Bare)]
        public string GetVisitsTimeByWeek(string uid, string pid, string week)
        {
            throw new NotImplementedException();
        }
    }
}