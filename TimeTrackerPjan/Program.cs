using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTrackerPjan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 

        //Program By Peter Janssen
        //IC17ao.e
        //18 september 2019
        public const double Version = 0.2;

        [STAThread]
        static void Main()
        {
            try
            {
                Log.Write("TimeTracker by Peter Janssen");
                Log.Write("Application Version " + Version.ToString());
                Log.Write("Start the application");
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new MyApplicationContext());
            }
            catch (Exception exception)
            {
                Log.Write(exception.ToString());
                DialogResult WriteLog = MessageBox.Show("An unexpected error has occured. Would you like to save a log?", "Error", MessageBoxButtons.YesNo);
                if (WriteLog == DialogResult.Yes)
                {
                    Log.Save();
                }
            }
        }
    }
}
