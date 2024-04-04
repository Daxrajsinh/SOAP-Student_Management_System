﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UploadDocsRef
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DocModel", Namespace="http://schemas.datacontract.org/2004/07/SMS_Services.Services")]
    public partial class DocModel : object
    {
        
        private string c_idField;
        
        private byte[] fileBytesField;
        
        private string nameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string c_id
        {
            get
            {
                return this.c_idField;
            }
            set
            {
                this.c_idField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] fileBytes
        {
            get
            {
                return this.fileBytesField;
            }
            set
            {
                this.fileBytesField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string name
        {
            get
            {
                return this.nameField;
            }
            set
            {
                this.nameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="UploadDocsRef.IUploadDocs")]
    public interface IUploadDocs
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUploadDocs/upload_documents", ReplyAction="http://tempuri.org/IUploadDocs/upload_documentsResponse")]
        void upload_documents(UploadDocsRef.DocModel dm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUploadDocs/upload_documents", ReplyAction="http://tempuri.org/IUploadDocs/upload_documentsResponse")]
        System.Threading.Tasks.Task upload_documentsAsync(UploadDocsRef.DocModel dm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUploadDocs/get_documents", ReplyAction="http://tempuri.org/IUploadDocs/get_documentsResponse")]
        UploadDocsRef.DocModel[] get_documents(string cid);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IUploadDocs/get_documents", ReplyAction="http://tempuri.org/IUploadDocs/get_documentsResponse")]
        System.Threading.Tasks.Task<UploadDocsRef.DocModel[]> get_documentsAsync(string cid);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IUploadDocsChannel : UploadDocsRef.IUploadDocs, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class UploadDocsClient : System.ServiceModel.ClientBase<UploadDocsRef.IUploadDocs>, UploadDocsRef.IUploadDocs
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public UploadDocsClient() : 
                base(UploadDocsClient.GetDefaultBinding(), UploadDocsClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IUploadDocs.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UploadDocsClient(EndpointConfiguration endpointConfiguration) : 
                base(UploadDocsClient.GetBindingForEndpoint(endpointConfiguration), UploadDocsClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UploadDocsClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(UploadDocsClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UploadDocsClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(UploadDocsClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public UploadDocsClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void upload_documents(UploadDocsRef.DocModel dm)
        {
            base.Channel.upload_documents(dm);
        }
        
        public System.Threading.Tasks.Task upload_documentsAsync(UploadDocsRef.DocModel dm)
        {
            return base.Channel.upload_documentsAsync(dm);
        }
        
        public UploadDocsRef.DocModel[] get_documents(string cid)
        {
            return base.Channel.get_documents(cid);
        }
        
        public System.Threading.Tasks.Task<UploadDocsRef.DocModel[]> get_documentsAsync(string cid)
        {
            return base.Channel.get_documentsAsync(cid);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUploadDocs))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IUploadDocs))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/SMS_Services/Services/UploadDocs");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return UploadDocsClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IUploadDocs);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return UploadDocsClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IUploadDocs);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IUploadDocs,
        }
    }
}