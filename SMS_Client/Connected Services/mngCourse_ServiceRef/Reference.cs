﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mngCourse_ServiceRef
{
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Course", Namespace="http://schemas.datacontract.org/2004/07/SMS_Services.Services")]
    public partial class Course : object
    {
        
        private int CourseIdField;
        
        private string CourseNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CourseId
        {
            get
            {
                return this.CourseIdField;
            }
            set
            {
                this.CourseIdField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CourseName
        {
            get
            {
                return this.CourseNameField;
            }
            set
            {
                this.CourseNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="mngCourse_ServiceRef.IManageCourse")]
    public interface IManageCourse
    {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManageCourse/AddCourse", ReplyAction="http://tempuri.org/IManageCourse/AddCourseResponse")]
        void AddCourse(mngCourse_ServiceRef.Course course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManageCourse/AddCourse", ReplyAction="http://tempuri.org/IManageCourse/AddCourseResponse")]
        System.Threading.Tasks.Task AddCourseAsync(mngCourse_ServiceRef.Course course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManageCourse/GetCourses", ReplyAction="http://tempuri.org/IManageCourse/GetCoursesResponse")]
        mngCourse_ServiceRef.Course[] GetCourses();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManageCourse/GetCourses", ReplyAction="http://tempuri.org/IManageCourse/GetCoursesResponse")]
        System.Threading.Tasks.Task<mngCourse_ServiceRef.Course[]> GetCoursesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManageCourse/UpdateCourse", ReplyAction="http://tempuri.org/IManageCourse/UpdateCourseResponse")]
        void UpdateCourse(mngCourse_ServiceRef.Course course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManageCourse/UpdateCourse", ReplyAction="http://tempuri.org/IManageCourse/UpdateCourseResponse")]
        System.Threading.Tasks.Task UpdateCourseAsync(mngCourse_ServiceRef.Course course);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManageCourse/DeleteCourse", ReplyAction="http://tempuri.org/IManageCourse/DeleteCourseResponse")]
        void DeleteCourse(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IManageCourse/DeleteCourse", ReplyAction="http://tempuri.org/IManageCourse/DeleteCourseResponse")]
        System.Threading.Tasks.Task DeleteCourseAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public interface IManageCourseChannel : mngCourse_ServiceRef.IManageCourse, System.ServiceModel.IClientChannel
    {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Tools.ServiceModel.Svcutil", "2.1.0")]
    public partial class ManageCourseClient : System.ServiceModel.ClientBase<mngCourse_ServiceRef.IManageCourse>, mngCourse_ServiceRef.IManageCourse
    {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public ManageCourseClient() : 
                base(ManageCourseClient.GetDefaultBinding(), ManageCourseClient.GetDefaultEndpointAddress())
        {
            this.Endpoint.Name = EndpointConfiguration.BasicHttpBinding_IManageCourse.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ManageCourseClient(EndpointConfiguration endpointConfiguration) : 
                base(ManageCourseClient.GetBindingForEndpoint(endpointConfiguration), ManageCourseClient.GetEndpointAddress(endpointConfiguration))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ManageCourseClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(ManageCourseClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress))
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ManageCourseClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(ManageCourseClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress)
        {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public ManageCourseClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        
        public void AddCourse(mngCourse_ServiceRef.Course course)
        {
            base.Channel.AddCourse(course);
        }
        
        public System.Threading.Tasks.Task AddCourseAsync(mngCourse_ServiceRef.Course course)
        {
            return base.Channel.AddCourseAsync(course);
        }
        
        public mngCourse_ServiceRef.Course[] GetCourses()
        {
            return base.Channel.GetCourses();
        }
        
        public System.Threading.Tasks.Task<mngCourse_ServiceRef.Course[]> GetCoursesAsync()
        {
            return base.Channel.GetCoursesAsync();
        }
        
        public void UpdateCourse(mngCourse_ServiceRef.Course course)
        {
            base.Channel.UpdateCourse(course);
        }
        
        public System.Threading.Tasks.Task UpdateCourseAsync(mngCourse_ServiceRef.Course course)
        {
            return base.Channel.UpdateCourseAsync(course);
        }
        
        public void DeleteCourse(int id)
        {
            base.Channel.DeleteCourse(id);
        }
        
        public System.Threading.Tasks.Task DeleteCourseAsync(int id)
        {
            return base.Channel.DeleteCourseAsync(id);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync()
        {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration)
        {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IManageCourse))
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
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IManageCourse))
            {
                return new System.ServiceModel.EndpointAddress("http://localhost:8733/Design_Time_Addresses/SMS_Services/Services/ManageCourse");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.Channels.Binding GetDefaultBinding()
        {
            return ManageCourseClient.GetBindingForEndpoint(EndpointConfiguration.BasicHttpBinding_IManageCourse);
        }
        
        private static System.ServiceModel.EndpointAddress GetDefaultEndpointAddress()
        {
            return ManageCourseClient.GetEndpointAddress(EndpointConfiguration.BasicHttpBinding_IManageCourse);
        }
        
        public enum EndpointConfiguration
        {
            
            BasicHttpBinding_IManageCourse,
        }
    }
}
