using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Healthcare_UI
{
    public partial class searchdocument : Form
    {
        public searchdocument()
        {
            InitializeComponent();
        }

        private void searchdocument_previousewindow_Click(object sender, EventArgs e)
        {
            //clear all fields
            this.searchdocument_textbox_patientid.Text = "";
            this.searchdocument_textbox_dov.Text = "";
            this.searchdocument_textbox_keyword1.Text = "";
            this.searchdocument_textbox_keyword2.Text = "";

            this.searchdocument_textbox_results.Text = "";

            this.Hide();
            Form x = new optionsmenu();
            Program.monitor.request_window(x, true);
        }
    }
}