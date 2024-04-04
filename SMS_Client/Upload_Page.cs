using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static SMS_Client.Upload_Page;

namespace SMS_Client
{
    public partial class Upload_Page : Form
    {
        private List<Document> uploadedDocuments = new List<Document>();
        public Upload_Page()
        {
            InitializeComponent();
            DisplayCourses();
        }
        private void DisplayCourses()
        {
            mngCourse_ServiceRef.ManageCourseClient sc = new mngCourse_ServiceRef.ManageCourseClient();
            mngCourse_ServiceRef.Course[] courseArray = sc.GetCourses();
            sc.Close();

            List<mngCourse_ServiceRef.Course> courses = new List<mngCourse_ServiceRef.Course>(courseArray);

            dataGridView1.AutoGenerateColumns = false; // Disable auto-generation of columns

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("CourseId", "Course ID");
            dataGridView1.Columns.Add("CourseName", "Course Name");

            // Add courses to DataGridView manually
            foreach (var course in courses)
            {
                dataGridView1.Rows.Add(course.CourseId, course.CourseName);
            }
        }

        private void DisplayUploadedDocuments()
        {
            dataGridView2.AutoGenerateColumns = false; // Disable auto-generation of columns

            dataGridView2.Columns.Clear();
            dataGridView2.Columns.Add("File_name", "Selected File(s)");

            foreach (var document in uploadedDocuments)
            {
                dataGridView2.Rows.Add(document.Name);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in openFileDialog.FileNames)
                {
                    byte[] fileContent = File.ReadAllBytes(fileName);

                    Document document = new Document
                    {
                        Name = Path.GetFileName(fileName),
                        Content = fileContent
                    };
                    uploadedDocuments.Add(document);

                    DisplayUploadedDocuments();
                }
            }
        }

        public class Document
        {
            public string? Name { get; set; }
            public byte[]? Content { get; set; }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string? cid;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                cid = dataGridView1.SelectedRows[0].Cells["CourseId"].Value.ToString();
                UploadDocsRef.UploadDocsClient uc = new UploadDocsRef.UploadDocsClient();
                foreach (var document in uploadedDocuments)
                {
                    uc.upload_documents(new UploadDocsRef.DocModel { c_id = cid, fileBytes = document.Content, name = document.Name });
                }
                MessageBox.Show("File(s) Uploaded successfully !");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Courses_page obj = new Courses_page();
            obj.Show();
            this.Hide();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string? cid;
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView3.Columns.Clear();
                dataGridView3.Columns.Add("File_name", "File(s) Uploaded");
                cid = dataGridView1.SelectedRows[0].Cells["CourseId"].Value.ToString();
                UploadDocsRef.UploadDocsClient uc = new UploadDocsRef.UploadDocsClient();
                List<UploadDocsRef.DocModel> docs = uc.get_documents(cid).ToList();
                foreach (var doc in docs)
                {
                    dataGridView3.Rows.Add(doc.name);
                }
            }
        }
    }
}
