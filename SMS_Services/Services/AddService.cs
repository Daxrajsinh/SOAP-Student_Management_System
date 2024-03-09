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
    public class AddService : IAddService
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Con_string"].ConnectionString;

        public void AddStudentData(Student student)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO Students (SName, SAddress, SEmail, SPhone_no, Sem, Fees_paid)
                                VALUES (@SName, @SAddress, @SEmail, @SPhone_no, @Sem, @Fees_paid)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@SName", student.SName);
                command.Parameters.AddWithValue("@SAddress", student.SAddress);
                command.Parameters.AddWithValue("@SEmail", student.SEmail);
                command.Parameters.AddWithValue("@SPhone_no", student.SPhone_no);
                command.Parameters.AddWithValue("@Sem", student.Sem);
                command.Parameters.AddWithValue("@Fees_paid", student.Fees_paid);
                command.ExecuteNonQuery();
            }
        }
    }
}
