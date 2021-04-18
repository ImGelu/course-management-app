using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (Properties.Settings.Default.rememberMe && Properties.Settings.Default.loggedInUserId != 0)
            {
                Application.Run(new FormDashboard());
            } else
            {
                Application.Run(new FormLogin());
            }
        }
    }
}
