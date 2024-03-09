using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SMS_Services.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Con_string"].ConnectionString;

        public bool isValidated(string uname, string passwd)
        {
            bool isValid = false;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND Password = @Password";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", uname);
                command.Parameters.AddWithValue("@Password", passwd);

                int count = (int)command.ExecuteScalar();

                if (count > 0)
                {
                    isValid = true;
                }
            }

            return isValid;
        }
    }
}
