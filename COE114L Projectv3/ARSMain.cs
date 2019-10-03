using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COE114L_Projectv3
{
    static class ARSMain
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            if (!File.Exists("ARS_Accounts.txt"))
            {
                File.Create("ARS_Accounts.txt");
            }
            if (!File.Exists("ARS_ReportsList.txt"))
            {
                File.Create("ARS_ReportsList.txt");
            }
            if (!File.Exists("ARS_CurrentLogin.txt"))
            {
                File.Create("ARS_CurrentLogin.txt");
            }
            if (!File.Exists("ARS_Help.txt"))
            {
                File.Create("ARS_Help.txt");
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
