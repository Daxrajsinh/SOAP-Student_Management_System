﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMS_Client
{
    public partial class Student_page : Form
    {
        private int StudentId;
        public Student_page(int StudentId)
        {
            InitializeComponent();
            this.StudentId = StudentId;
            Console.WriteLine(StudentId);
            DisplayStudentInfo();
            FetchCourses();
        }

        void DisplayStudentInfo()
        {
            disp_ServiceRef.DisplayServiceClient sc3 = new disp_ServiceRef.DisplayServiceClient();
            disp_ServiceRef.Student st = sc3.GetStudentInfo(StudentId);
            sc3.Close();

            if (st != null)
            {
                label9.Text = st.SId.ToString();
                label10.Text = st.SName.ToString();
                label11.Text = st.SAddress.ToString();
                label12.Text = st.SEmail.ToString();
                label13.Text = st.SPhone_no.ToString();
                label14.Text = st.Sem.ToString();
                label15.Text = st.Fees_paid.ToString();
                label17.Text = st.Grades.ToString();
            }
            else
            {
                MessageBox.Show("No student information record found !");
                label9.Text = "";
                label10.Text = "";
                label11.Text = "";
                label12.Text = "";
                label13.Text = "";
                label14.Text = "";
                label15.Text = "";
                label17.Text = "";
            }
        }

        void FetchCourses()
        {
            mngCourse_ServiceRef.ManageCourseClient sc4 = new mngCourse_ServiceRef.ManageCourseClient();
            mngCourse_ServiceRef.Course[] courses = sc4.GetCourses();
            foreach (var course in courses)
            {
                comboBox1.Items.Add(course.CourseName);
            }
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login_page obj = new Login_page();
            obj.Show();
            this.Hide();
        }
    }
}
