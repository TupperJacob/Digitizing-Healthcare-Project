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
        }

        private void employee_button_login_Click(object sender, EventArgs e)
        {
            //Password needs to be hashed before passing to Program.monitor.passinfo
            byte[] username = Encoding.UTF8.GetBytes(this.employeelogin_textbox_username.Text);
            byte[] password = Encoding.UTF8.GetBytes(this.employeelogin_textbox_password.Text);

            //hash here

            //end of hash

            //passinfo has return type of bool to quickly determin if username and hashed password matches with stored hash in database
            if(Program.monitor.passinfo(username, password))
            {
                //Clear fields before leaving form
                this.employeelogin_textbox_password.Text = "";
                this.employeelogin_textbox_username.Text = "";
                this.Hide();
                Form x = new optionsmenu();
                Program.monitor.request_window(x, true);
            }
            else { MessageBox.Show("Incorrect Username or Password"); }
            //TODO: Make form itself show content of this messagebox instead of using a messagebox
        }
    }
}
