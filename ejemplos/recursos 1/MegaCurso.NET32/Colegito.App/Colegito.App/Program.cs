using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Colegito.Domain;
using Colegito.Services;


namespace Colegito.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            IServiceInjector injector = new ServiceInjector();

            //bind query service
            injector.Bind<IDepartmentQueryService, DepartmentQueryService>();
            injector.Bind<ITeacherQueryService, TeacherQueryService>();


            //bind forms
            injector.Bind<fMain, fMain>();


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            //init main form thru service injector
            Application.Run(injector.Get<fMain>());
        }
    }
}
