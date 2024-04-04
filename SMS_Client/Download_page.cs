using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UploadDocsRef;

namespace SMS_Client
{
    public partial class Download_page : Form
    {
        List<mngCourse_ServiceRef.Course> courses1;
        private int studentid;
        public Download_page(List<mngCourse_ServiceRef.Course> courses, int sid)
        {
            courses1 = courses;
            this.studentid = sid;
            InitializeComponent();
            FetchCourses(courses);
        }
        void FetchCourses(List<mngCourse_ServiceRef.Course> courses)
        {
            foreach (var course in courses)
            {
                comboBox1.Items.Add(course.CourseName);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mngCourse_ServiceRef.Course c = courses1[comboBox1.SelectedIndex];
            string cid = c.CourseId.ToString();

            UploadDocsRef.UploadDocsClient uc = new UploadDocsRef.UploadDocsClient();
            List<DocModel> docs = uc.get_documents(cid).ToList();

            FlowLayoutPanel flowLayoutPanelDocuments = new FlowLayoutPanel();
            flowLayoutPanelDocuments.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelDocuments.AutoScroll = true;
            flowLayoutPanelDocuments.Location = new System.Drawing.Point(20, 100);
            flowLayoutPanelDocuments.Size = new Size(500, 300);
            foreach (var doc in docs)
            {
                // Create a panel to contain each file and its download button
                Panel panel = new Panel();
                panel.AutoSize = true;

                // Button for download
                Button btnDownload = new Button();
                btnDownload.AutoSize = true;
                btnDownload.Text = doc.name;
                btnDownload.Tag = doc;
                btnDownload.Click += BtnDownload_Click;

                // Add label and button to the panel
                panel.Controls.Add(btnDownload);

                // Add panel to the flow layout panel
                flowLayoutPanelDocuments.Controls.Add(panel);
            }

            // Add the flow layout panel to the form's controls
            Controls.Add(flowLayoutPanelDocuments);


        }
        private void BtnDownload_Click(object sender, EventArgs e)
        {
            Button btnDownload = (Button)sender;
            DocModel document = (DocModel)btnDownload.Tag;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = document.name; // Default file name
            saveFileDialog.Filter = "All Files|*.*";  // Set appropriate file filters if needed

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Save the document content to the selected file location
                File.WriteAllBytes(saveFileDialog.FileName, document.fileBytes);

                MessageBox.Show($"File '{document.name}' downloaded successfully.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student_page obj = new Student_page(studentid);
            obj.Show();
            this.Hide();
        }
    }
}
