using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MegaCurso.NET20
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


            string language = System.Configuration.ConfigurationManager.AppSettings["language"];

            System.Threading.Thread.CurrentThread.CurrentCulture =
                new System.Globalization.CultureInfo(language);

            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new System.Globalization.CultureInfo(language);


            Application.Run(new fMain());
        }
    }
}
