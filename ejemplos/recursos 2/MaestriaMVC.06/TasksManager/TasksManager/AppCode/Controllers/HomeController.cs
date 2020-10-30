using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

using TasksManager.ViewModels;
using TasksManager.QueryServices;


namespace TasksManager.AppCode.Controllers
{

    public class HomeController : Controller
    {

        /// <summary>
        /// Constructor, initialize list of tasks
        /// </summary>
        public HomeController()
        {
        }


        /// <summary>
        /// Get index view
        /// </summary>
        public ActionResult Index()
        {
            return View("IndexView");
        }




    }
}