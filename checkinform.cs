using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Healthcare_UI
{
    public partial class checkinform : Form
    {
        public checkinform()
        {
           
            InitializeComponent();
        }

        private void checkinform_Load(object sender, EventArgs e)
        {

        }

        private void checkinform_button_goback_Click(object sender, EventArgs e)
        {
            //Remove all content before leaving
            this.checkinform_radial_option1.Checked = false;
            this.checkinform_radial_option2.Checked = false;
            this.checkinform_radial_option3.Checked = false;
            this.checkinform_radial_option4.Checked = false;
            this.checkinform_radial_option5.Checked = false;
            this.checkinform_radial_option6.Checked = false;
            this.checkinform_radial_option7.Checked = false;
            this.checkinform_radial_option8.Checked = false;

            this.checkinform_radial_male.Checked = false;
            this.checkinform_radial_female.Checked = false;

            this.checkinform_textbox_additionalnotes.Text = "";
            this.checkinform_textbox_email.Text = "";
            this.checkinform_textbox_name.Text = "";
            this.checkinform_textbox_dob.Text = "";
           
            this.checkinform_textbox_street.Text = "";
            this.checkinform_textbox_city.Text = "";
            this.checkinform_textbox_state.Text = "";
            this.checkinform_textbox_zip.Text = "";
            this.checkinform_textbox_suit_room_number.Text = "";
            this.checkinform_textbox_pobox.Text = "";





            this.Hide();
            Form x = new optionsmenu();
            Program.monitor.request_window(x, true); //monitor will handle if logged on or not and bring appropriate window up
        }
    }
}
