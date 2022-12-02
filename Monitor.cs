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
    public class Monitor : Form
    {
        //actual windows:
        private static Form window_checkinform = new checkinform();
        private static Form window_optionsmenu = new optionsmenu();
        private static Form window_searchdocument = new searchdocument();
        private static Form window_selectmode = new selectmode();
        private static Form window_upload = new upload();
        private static Form window_employeelogin = new employeelogin();
        private static Form window_main = new main(false);
    
        //variables
        private bool logged_on = false;

        public Monitor() //Pass the forms to monitor
        {
           
        }

        public Form start() //lmao stupid but works, Application() not in monitors scope but is in program
        {
            return window_main;
        }
        private void change_window(Form form)
        {//switch with Form type only allowed in c# 9.0 only available in .NET 5
         //cannot install without mssu employee with password >:(
            if (form is checkinform)
                window_checkinform.Show();
            else if (form is optionsmenu)
            {//only logged in employees should go to options, otherwise main
                if (logged_on)
                    window_optionsmenu.Show();
                else
                    window_main.Show(); 
            }
            else if (form is searchdocument)
                window_searchdocument.Show();
            else if (form is selectmode)
                window_selectmode.Show();
            else if (form is upload)
                window_upload.Show();
            else if (form is employeelogin)
                window_employeelogin.Show();
            else if (form is main)
               window_main.Show();
            else window_main.Show(); //default
        }

        public bool request_window(Form form, bool perform_now)
        {
            bool test = true; //for testing purposes;

            if (test)
            {
                if (perform_now)
                    change_window(form);
                return true;
            } else
            {
                return false;
            }

            
        }

        public bool passinfo(Byte[] username, Byte[] hashed_password) //Beware: Speghetti code below with multiple returns!
        {
            //make sure everything being passed is UTF8
            Byte[] dummyUsername = Encoding.UTF8.GetBytes("user");
            Byte[] dummyPassword = Encoding.UTF8.GetBytes("pass");

            //arrays the same length?
            if (username.Length == dummyUsername.Length && hashed_password.Length == dummyPassword.Length)
            {
                //test username first
                for (int i = 0; i < username.Length; i++)
                {
                    if (username[i] != dummyUsername[i])
                    {
                        logged_on = false;
                        return logged_on;
                    }
                    else logged_on = true;
                }
                
                //test password next
                for (int i = 0; i < hashed_password.Length; i++)
                {
                    if (hashed_password[i] != dummyPassword[i])
                    {
                        logged_on = false;
                        return logged_on;
                    }
                    else logged_on = true;
                }
            }
            else
            {
                logged_on = false; 
                return false;
            }
            return logged_on; //default
        }

        public bool loggout()
        {
            logged_on = false;
            return true;
        }






    }//end of class
}//end of namespace
