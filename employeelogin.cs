using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Healthcare_UI
{
    public partial class employeelogin : Form
    {
        public employeelogin()
        {
            InitializeComponent();
        }

        private void employeelogin_button_goback_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form x = new main(false);
            Program.monitor.request_window(x, true);
            //window_welcome.form_welcome.Show();
        }

        private void employee_button_login_Click(object sender, EventArgs e)
        {
            //Steps:
            //1: Parse Username into byte array
            //2: Parse Password into byte array
            //3: Hash the password locally
            //4: Pass into Program.monitor.passinfo()

            byte[] username = Encoding.UTF8.GetBytes(this.employeelogin_textbox_username.Text);
            byte[] password = Encoding.UTF8.GetBytes(this.employeelogin_textbox_password.Text);

            //hash here

            //end of hash

            //pass info

            if(Program.monitor.passinfo(username, password))
            {
                //remove text
                this.employeelogin_textbox_password.Text = "";
                this.employeelogin_textbox_username.Text = "";
                this.Hide();
                Form x = new optionsmenu();
                Program.monitor.request_window(x, true);
            }
            else { MessageBox.Show("Incorrect Username or Password"); }


            
        }
    }
}
