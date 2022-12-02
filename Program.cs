using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Healthcare_UI
{
    
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// 
         /*************************
         ***DO NOT EDIT THIS PAGE*** 
          *************************/
        public static Monitor monitor = new Monitor(); //The monitor class as mentioned in main notes (Program.monitor)
        [STAThread]
        static void Main()
        {
            
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new main(false)); main initialized inside monitor so 
            Application.Run(monitor.start());
        }
    }
}
