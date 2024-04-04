using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Services.Services
{

    public class UploadDocs : IUploadDocs
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["Con_string"].ConnectionString;

        public IEnumerable<DocModel> get_documents(string cid)
        {
            List<DocModel> docs = new List<DocModel>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT * FROM Documents WHERE course_id = @cid";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@cid", cid);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DocModel doc = new DocModel
                            {
                                name = reader["dname"].ToString(),
                                fileBytes = FileService.GetFile(reader["file_path"].ToString()),
                                c_id = reader["course_id"].ToString()
                            };
                            docs.Add(doc);
                        }
                    }
                }
            }
            return docs;
        }

        public void upload_documents(DocModel doc)
        {
            using (SqlConnection connection = new SqlConnection(connectionString)) // Replace connectionString with your actual connection string
            {
                try
                {
                    connection.Open();

                    string query = @"INSERT INTO Documents (dname, file_path, course_id) VALUES (@dname, @file_path, @course_id)";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    string path = FileService.UploadFile(doc.name, doc.fileBytes);
                    cmd.Parameters.AddWithValue("@dname", doc.name);
                    cmd.Parameters.AddWithValue("@file_path", path);
                    cmd.Parameters.AddWithValue("@course_id", doc.c_id);

                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        // Insert successful
                        MessageBox.Show("Document inserted successfully.");
                    }
                    else
                    {
                        // Insert failed
                        MessageBox.Show("Failed to insert document.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

        }
    }
}