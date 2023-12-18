using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Doctor_By_Side
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(true);
            var login = new Login_Screen();
            login.FormClosed += new FormClosedEventHandler(FormClosed);
            login.Show();
            Application.Run();
            //Application.Run(new Login_Screen());
        }
        static void FormClosed(object sender, FormClosedEventArgs e)
        {
            ((Form)sender).FormClosed -= FormClosed;
            if (Application.OpenForms.Count == 0) Application.ExitThread();
            else Application.OpenForms[0].FormClosed += FormClosed;
        }
    }
}
