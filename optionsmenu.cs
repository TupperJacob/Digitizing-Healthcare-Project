using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Healthcare_UI
{
    public partial class optionsmenu : Form
    {
        public optionsmenu()
        {
            InitializeComponent();
        }

        private void optionsmenu_button_logout_Click(object sender, EventArgs e)
        {


            //pass information to class removing account information, effectively resetting the class.
            Program.monitor.loggout();
            this.Hide();
            Form x = new main(false);
            Program.monitor.request_window(x, true);
        }

        private void optionsmenu_button_input_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form x = new checkinform();
            Program.monitor.request_window(x, true);
        }

        private void optionsmenu_button_upload_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form x = new upload();
            Program.monitor.request_window(x, true);
        }

        private void optionsmenu_button_search_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form x = new searchdocument();
            Program.monitor.request_window(x, true);
        }
    }
}
