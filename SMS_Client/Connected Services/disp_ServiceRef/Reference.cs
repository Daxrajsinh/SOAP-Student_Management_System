﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace disp_ServiceRef
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/SMS_Services.Services")]
    public partial class Student : object
    {
        
        private string Fees_paidField;
        
        private string GradesField;
        
        private string SAddressField;
        
        private string SEmailField;
        
        private int SIdField;
        
        private string SNameField;
        
        private string SPhone_noField;
        
        private int SemField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Fees_paid
        {
            get
            {
                return this.Fees_paidField;
            }
            set
            {
                this.Fees_paidField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Grades
        {
            get
            {
                return this.GradesField;
            }
            set
            {
                this.GradesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SAddress
        {
            get
            {
                return this.SAddressField;
            }
            set
            {
                this.SAddressField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SEmail
        {
            get
            {
                return this.SEmailField;
            }
            set
            {
                this.SEmailField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SId
        {
            get
            {
                return this.SIdField;
            }
            set
            {
                this.SIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SName
        {
            get
            {
                return this.SNameField;
            }
            set
            {
                this.SNameField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SPhone_no
        {
            get
            {
                return this.SPhone_noField;
            }
            set
            {
                this.SPhone_noField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Sem
        {
            get
            {
                return this.SemField;
            }
            set
            {
                this.SemField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="disp_ServiceRef.IDisplayService")]
    public interface IDisplayService
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDisplayService/GetStudents", ReplyAction="http://tempuri.org/IDisplayService/GetStudentsResponse")]
        disp_ServiceRef.Student[] GetStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDisplayService/GetStudents", ReplyAction="http://tempuri.org/IDisplayService/GetStudentsResponse")]
        System.Threading.Tasks.Task<disp_ServiceRef.Student[]> GetStudentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IDisplayServiceChannel : disp_ServiceRef.IDisplayService, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class DisplayServiceClient : System.ServiceModel.ClientBase<disp_ServiceRef.IDisplayService>, disp_ServiceRef.IDisplayService
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public DisplayServiceClient() : 
                base(DisplayServiceClient.GetDefaultBinding(), DisplayServiceClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IDisplayService.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DisplayServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(DisplayServiceClient.GetBindingForEndpoint(endpointConfiguration), DisplayServiceClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DisplayServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(DisplayServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DisplayServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(DisplayServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public DisplayServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public disp_ServiceRef.Student[] GetStudents()
        {
            return base.Channel.GetStudents();
        }
        
        public System.Threading.Tasks.Task<disp_ServiceRef.Student[]> GetStudentsAsync()
        {
            return base.Channel.GetStudentsAsync();
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IDisplayService))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IDisplayService))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/SMS_Services/Services/DisplayService");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return DisplayServiceClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IDisplayService);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return DisplayServiceClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IDisplayService);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IDisplayService,
        }
    }
}
