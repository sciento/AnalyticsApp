﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnalyticsApp.Embed {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="Embed.IEmbedService")]
    public interface IEmbedService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmbedService/GetScript", ReplyAction="http://tempuri.org/IEmbedService/GetScriptResponse")]
        string GetScript(string id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IEmbedService/GetScript", ReplyAction="http://tempuri.org/IEmbedService/GetScriptResponse")]
        System.Threading.Tasks.Task<string> GetScriptAsync(string id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IEmbedServiceChannel : AnalyticsApp.Embed.IEmbedService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class EmbedServiceClient : System.ServiceModel.ClientBase<AnalyticsApp.Embed.IEmbedService>, AnalyticsApp.Embed.IEmbedService {
        
        public EmbedServiceClient() {
        }
        
        public EmbedServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public EmbedServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmbedServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public EmbedServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetScript(string id) {
            return base.Channel.GetScript(id);
        }
        
        public System.Threading.Tasks.Task<string> GetScriptAsync(string id) {
            return base.Channel.GetScriptAsync(id);
        }
    }
}
