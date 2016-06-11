﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnalyticsApp.Analyse {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Analyse.IAnalyseSerivce")]
    public interface IAnalyseSerivce {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetMost", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetMostResponse")]
        string GetMost(string uid, string pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetMost", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetMostResponse")]
        System.Threading.Tasks.Task<string> GetMostAsync(string uid, string pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetMostByDate", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetMostByDateResponse")]
        string GetMostByDate(string uid, string pid, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetMostByDate", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetMostByDateResponse")]
        System.Threading.Tasks.Task<string> GetMostByDateAsync(string uid, string pid, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetMostByWeek", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetMostByWeekResponse")]
        string GetMostByWeek(string uid, string pid, string week);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetMostByWeek", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetMostByWeekResponse")]
        System.Threading.Tasks.Task<string> GetMostByWeekAsync(string uid, string pid, string week);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsTimeAll", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsTimeAllResponse")]
        string GetVisitsTimeAll(string uid, string pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsTimeAll", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsTimeAllResponse")]
        System.Threading.Tasks.Task<string> GetVisitsTimeAllAsync(string uid, string pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsTimeByDay", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsTimeByDayResponse")]
        string GetVisitsTimeByDay(string uid, string pid, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsTimeByDay", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsTimeByDayResponse")]
        System.Threading.Tasks.Task<string> GetVisitsTimeByDayAsync(string uid, string pid, string date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsTimeByWeek", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsTimeByWeekResponse")]
        string GetVisitsTimeByWeek(string uid, string pid, string week);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsTimeByWeek", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsTimeByWeekResponse")]
        System.Threading.Tasks.Task<string> GetVisitsTimeByWeekAsync(string uid, string pid, string week);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsByBrowser", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsByBrowserResponse")]
        string GetVisitsByBrowser(string uid, string pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsByBrowser", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsByBrowserResponse")]
        System.Threading.Tasks.Task<string> GetVisitsByBrowserAsync(string uid, string pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsByOs", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsByOsResponse")]
        string GetVisitsByOs(string uid, string pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsByOs", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsByOsResponse")]
        System.Threading.Tasks.Task<string> GetVisitsByOsAsync(string uid, string pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsByCountry", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsByCountryResponse")]
        string GetVisitsByCountry(string uid, string pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsByCountry", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsByCountryResponse")]
        System.Threading.Tasks.Task<string> GetVisitsByCountryAsync(string uid, string pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsByReferral", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsByReferralResponse")]
        string GetVisitsByReferral(string uid, string pid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAnalyseSerivce/GetVisitsByReferral", ReplyAction="http://tempuri.org/IAnalyseSerivce/GetVisitsByReferralResponse")]
        System.Threading.Tasks.Task<string> GetVisitsByReferralAsync(string uid, string pid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAnalyseSerivceChannel : AnalyticsApp.Analyse.IAnalyseSerivce, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AnalyseSerivceClient : System.ServiceModel.ClientBase<AnalyticsApp.Analyse.IAnalyseSerivce>, AnalyticsApp.Analyse.IAnalyseSerivce {
        
        public AnalyseSerivceClient() {
        }
        
        public AnalyseSerivceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AnalyseSerivceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AnalyseSerivceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AnalyseSerivceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetMost(string uid, string pid) {
            return base.Channel.GetMost(uid, pid);
        }
        
        public System.Threading.Tasks.Task<string> GetMostAsync(string uid, string pid) {
            return base.Channel.GetMostAsync(uid, pid);
        }
        
        public string GetMostByDate(string uid, string pid, string date) {
            return base.Channel.GetMostByDate(uid, pid, date);
        }
        
        public System.Threading.Tasks.Task<string> GetMostByDateAsync(string uid, string pid, string date) {
            return base.Channel.GetMostByDateAsync(uid, pid, date);
        }
        
        public string GetMostByWeek(string uid, string pid, string week) {
            return base.Channel.GetMostByWeek(uid, pid, week);
        }
        
        public System.Threading.Tasks.Task<string> GetMostByWeekAsync(string uid, string pid, string week) {
            return base.Channel.GetMostByWeekAsync(uid, pid, week);
        }
        
        public string GetVisitsTimeAll(string uid, string pid) {
            return base.Channel.GetVisitsTimeAll(uid, pid);
        }
        
        public System.Threading.Tasks.Task<string> GetVisitsTimeAllAsync(string uid, string pid) {
            return base.Channel.GetVisitsTimeAllAsync(uid, pid);
        }
        
        public string GetVisitsTimeByDay(string uid, string pid, string date) {
            return base.Channel.GetVisitsTimeByDay(uid, pid, date);
        }
        
        public System.Threading.Tasks.Task<string> GetVisitsTimeByDayAsync(string uid, string pid, string date) {
            return base.Channel.GetVisitsTimeByDayAsync(uid, pid, date);
        }
        
        public string GetVisitsTimeByWeek(string uid, string pid, string week) {
            return base.Channel.GetVisitsTimeByWeek(uid, pid, week);
        }
        
        public System.Threading.Tasks.Task<string> GetVisitsTimeByWeekAsync(string uid, string pid, string week) {
            return base.Channel.GetVisitsTimeByWeekAsync(uid, pid, week);
        }
        
        public string GetVisitsByBrowser(string uid, string pid) {
            return base.Channel.GetVisitsByBrowser(uid, pid);
        }
        
        public System.Threading.Tasks.Task<string> GetVisitsByBrowserAsync(string uid, string pid) {
            return base.Channel.GetVisitsByBrowserAsync(uid, pid);
        }
        
        public string GetVisitsByOs(string uid, string pid) {
            return base.Channel.GetVisitsByOs(uid, pid);
        }
        
        public System.Threading.Tasks.Task<string> GetVisitsByOsAsync(string uid, string pid) {
            return base.Channel.GetVisitsByOsAsync(uid, pid);
        }
        
        public string GetVisitsByCountry(string uid, string pid) {
            return base.Channel.GetVisitsByCountry(uid, pid);
        }
        
        public System.Threading.Tasks.Task<string> GetVisitsByCountryAsync(string uid, string pid) {
            return base.Channel.GetVisitsByCountryAsync(uid, pid);
        }
        
        public string GetVisitsByReferral(string uid, string pid) {
            return base.Channel.GetVisitsByReferral(uid, pid);
        }
        
        public System.Threading.Tasks.Task<string> GetVisitsByReferralAsync(string uid, string pid) {
            return base.Channel.GetVisitsByReferralAsync(uid, pid);
        }
    }
}