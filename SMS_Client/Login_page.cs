namespace SMS_Client
{
    public partial class Login_page : Form
    {
        public Login_page()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Missing Information");
                //label4.Text = "Missing Information";
            }
            else
            {
                auth_ServiceRef.AuthenticationServiceClient sc1 = new auth_ServiceRef.AuthenticationServiceClient();
                bool flag = sc1.isValidated(textBox1.Text, textBox2.Text);

                if (flag)
                {
                    //label4.Text = "DONE !";
                    Main_Page obj = new Main_Page();
                    obj.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials !");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}