﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace auth_ServiceRef
{
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="auth_ServiceRef.IAuthenticationService")]
    public interface IAuthenticationService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/ValidateUser", ReplyAction="http://tempuri.org/IAuthenticationService/ValidateUserResponse")]
        System.ValueTuple<bool, string, int> ValidateUser(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAuthenticationService/ValidateUser", ReplyAction="http://tempuri.org/IAuthenticationService/ValidateUserResponse")]
        System.Threading.Tasks.Task<System.ValueTuple<bool, string, int>> ValidateUserAsync(string username, string password);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IAuthenticationServiceChannel : auth_ServiceRef.IAuthenticationService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class AuthenticationServiceClient : System.ServiceModel.ClientBase<auth_ServiceRef.IAuthenticationService>, auth_ServiceRef.IAuthenticationService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public AuthenticationServiceClient() : 
                base(AuthenticationServiceClient.GetDefaultBinding(), AuthenticationServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IAuthenticationService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthenticationServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(AuthenticationServiceClient.GetBindingForEndpoint(endpointConfiguration), AuthenticationServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthenticationServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(AuthenticationServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthenticationServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(AuthenticationServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public AuthenticationServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public System.ValueTuple<bool, string, int> ValidateUser(string username, string password)
        {
            return base.Channel.ValidateUser(username, password);
        }
        
        public System.Threading.Tasks.Task<System.ValueTuple<bool, string, int>> ValidateUserAsync(string username, string password)
        {
            return base.Channel.ValidateUserAsync(username, password);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IAuthenticationService))
            {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IAuthenticationService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/SMS_Services/Services/AuthenticationS" +
                        "ervice");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return AuthenticationServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IAuthenticationService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return AuthenticationServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IAuthenticationService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IAuthenticationService,
        }
    }
}
