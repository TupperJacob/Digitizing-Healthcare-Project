using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Healthcare_UI
{
    public partial class upload : Form
    {
        public upload()
        {
            InitializeComponent();
        }

        private void upload_previousewindow_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form x = new optionsmenu();
            Program.monitor.request_window(x, true);
        }
    }
}
