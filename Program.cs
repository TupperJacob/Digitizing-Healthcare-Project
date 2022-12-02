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

        public static Monitor monitor = new Monitor(); //the main.monitor as mentioned in notes

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
