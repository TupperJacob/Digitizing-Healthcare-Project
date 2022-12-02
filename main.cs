using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_UI
{
/*
 * Made by Jacob D Tupper
 * Began 11-29-22
 * 
 * Test of the push Jacob Tupper 12/1/22
 * Test from remote computer
 * 
 * Notes Are below:
 * 
 * 
 * Contents:
 * I. To do's
 * 1. The different win Forms
 * 2. The monitor
 * 3. Issues with .NET 3.1
 * 
 * I. Remove fucking provanity from my fucking application, fucking fucky cunt
 * 
 * 
 * 
 * 1. The different win forms
 * 
 * 1A. main - This form was originally named window_welcome and changed to main because this is the real starting point of the application
 *           the other win forms can access this form so this is where the monitor lives which will provide security for the variables
 *           connection and whatnot. This form has the code for all that and also is the main form window, there is only a single lable
 *           and two buttons which have action methods by click which are below. They are Checkin (for patients) and a button for employee login
 *           
 * 1B. employeelogin - This is the form that have a two textboxes and two buttons. One textbox for username and one for password. One sumbit button
 *                    and one loggout button - this button will return to main and will also loggout of the current user. The only code in this form
 *                    will be passing the username as plain byte array and the password will be hashed; both will be passed to the main.monitor class
 *                    for evaluation and will either send a bool saying the credentials were correct and will bring up the options menu (or the selectmode
 *                    if applicable and or even if it is implemented).
 * 1C. selectmode - This form will send the selected option to the main.monitor class. The options are Host, Client and Offline. Host will make the main.monitor 
 *                  configure itself to listen to tcp packets and will accept request by other applications running in Client mode such as accept a file or retrieve a file
 *                  or search for a file given information in. The main.monitor will also see if a depository has been setup and will work as a SQL database that points to encrypted files
 *                  The Client mode will configure the main.monitor to work like the Host configuration but will not have its own depository but rather only send request to the HOst
 *                  The offline mode will configure the main.monitor to work like both the Host and Client but all information remains on the host computer, a depository and database will be setup
 *                  and all requests will be passed to the host computers main.monitor rather than over a socket.
 * 1D. optionsmenu - This form just changes between the different forms for a logged in employee. The buttons that send you to the next form as Make new Form (Same form that a patient goes to)
 *                   Upload, which uploads to a depository depending on mode selected. Download, which downloads from the depository depending on the mode selected.
 * 1E. upload and search document - these two may be combined since they both do very similar things. Uploading just uploads a document to the depository. Search document searches the depository 
 *                                  and database based on patient ID, name and a few keywords and shows the document name or similar results. The user can view, delete, rename, download, etc.
 */

    public partial class main : Form
    {
        public main(bool alreadyrunning)
        {
            if (!alreadyrunning)
            InitializeComponent();
        }
       
        //public static Monitor monitor = new Monitor(main); //the main.monitor as mentioned in notes

        private void window_button_checkin_Click(object sender, EventArgs e)
        {
            this.Hide(); 
            Form x = new checkinform(); //see notes section X why a new Form object is created every fucking time.
            Program.monitor.request_window(x, true); 
        }

        private void window_button_employeelogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form x = new employeelogin();
            Program.monitor.request_window(x, true);
            x = null;
        }
    }
}
