﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace TasksManager.AppCode.Controllers
{

    public class HomeController : Controller
    {

        private List<TaskDTO> _Tasks;


        /// <summary>
        /// Constructor, initialize list of tasks
        /// </summary>
        public HomeController()
        {
            _Tasks = new List<TaskDTO>()
            {
                new TaskDTO() { ID = 1, Name = "Pasear a mi perro", DueDate = DateTime.Now.AddDays(1) },
                new TaskDTO() { ID = 2, Name = "Tirar la basura", DueDate = DateTime.Now.AddDays(2) },
                new TaskDTO() { ID = 3, Name = "Llamar a mami", DueDate = DateTime.Now.AddDays(-1) },
            };
        }


        /// <summary>
        /// Get list of tasks
        /// </summary>
        public ActionResult Index()
        {
            ViewBag.ListOfTasks = _Tasks;
            return View("IndexView");
        }


        /// <summary>
        /// Get task view
        /// </summary>
        public ActionResult Task()
        {
            ViewBag.TestDiv = "<div>Hola soy testDiv</div>";
            return View("TaskView");
        }




    }
}