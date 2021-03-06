﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AnalyticsApp.AuthReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AuthReference.IAuthService")]
    public interface IAuthService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Auth", ReplyAction="http://tempuri.org/IAuthService/AuthResponse")]
        bool Auth([System.ServiceModel.MessageParameterAttribute(Name="auth")] AnalysticsLibrary.Models.AuthRequest auth1);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthService/Auth", ReplyAction="http://tempuri.org/IAuthService/AuthResponse")]
        System.Threading.Tasks.Task<bool> AuthAsync(AnalysticsLibrary.Models.AuthRequest auth);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAuthServiceChannel : AnalyticsApp.AuthReference.IAuthService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AuthServiceClient : System.ServiceModel.ClientBase<AnalyticsApp.AuthReference.IAuthService>, AnalyticsApp.AuthReference.IAuthService {
        
        public AuthServiceClient() {
        }
        
        public AuthServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Auth(AnalysticsLibrary.Models.AuthRequest auth1) {
            return base.Channel.Auth(auth1);
        }
        
        public System.Threading.Tasks.Task<bool> AuthAsync(AnalysticsLibrary.Models.AuthRequest auth) {
            return base.Channel.AuthAsync(auth);
        }
    }
}
