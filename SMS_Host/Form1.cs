using System;
using System.Windows.Forms;
using System.ServiceModel;
using SMS_Services;

namespace SMS_Host
{
    public partial class Form1 : Form
    {
        private ServiceHost addServiceHost;
        private ServiceHost authenticationServiceHost;
        private ServiceHost deleteServiceHost;
        private ServiceHost displayServiceHost;
        private ServiceHost updateServiceHost;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Host AddService
            Uri addServiceUri = new Uri("net.tcp://localhost:8000/Design_Time_Addresses/SMS_Services/Services/AddService/");
            addServiceHost = new ServiceHost(typeof(SMS_Services.Services.AddService), addServiceUri);
            addServiceHost.Open();

            // Host AuthenticationService
            Uri authenticationServiceUri = new Uri("net.tcp://localhost:8001/Design_Time_Addresses/SMS_Services/Services/AuthenticationService/");
            authenticationServiceHost = new ServiceHost(typeof(SMS_Services.Services.AuthenticationService), authenticationServiceUri);
            authenticationServiceHost.Open();

            // Host DeleteService
            Uri deleteServiceUri = new Uri("net.tcp://localhost:8002/Design_Time_Addresses/SMS_Services/Services/DeleteService/");
            deleteServiceHost = new ServiceHost(typeof(SMS_Services.Services.DeleteService), deleteServiceUri);
            deleteServiceHost.Open();

            // Host DisplayService
            Uri displayServiceUri = new Uri("net.tcp://localhost:8003/Design_Time_Addresses/SMS_Services/Services/DisplayService/");
            displayServiceHost = new ServiceHost(typeof(SMS_Services.Services.DisplayService), displayServiceUri);
            displayServiceHost.Open();

            // Host UpdateService
            Uri updateServiceUri = new Uri("net.tcp://localhost:8004/Design_Time_Addresses/SMS_Services/Services/UpdateService/");
            updateServiceHost = new ServiceHost(typeof(SMS_Services.Services.UpdateService), updateServiceUri);
            updateServiceHost.Open();

            label1.Text = "Service Running... !";
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            // Close all service hosts when the form is closed
            addServiceHost.Close();
            authenticationServiceHost.Close();
            deleteServiceHost.Close();
            displayServiceHost.Close();
            updateServiceHost.Close();
        }
    }
}