using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using TasksManager.QueryServices;
using TasksManager.ViewModels;


namespace TasksManager.Tasks
{
    public class TasksController : Controller
    {
        private TaskQueryService _taskQueryService;


        /// <summary>
        /// Constructor, initialize list of tasks
        /// </summary>
        public TasksController()
        {
            _taskQueryService = new TaskQueryService();
        }


        /// <summary>
        /// Get list of tasks
        /// </summary>
        public ActionResult Index()
        {
            TaskListViewModel model = new TaskListViewModel()
            {
                ListOfTasks = _taskQueryService.GetTasks()
            };

            return View("TaskListView", model);
        }


        /// <summary>
        /// Go to new task view
        /// </summary>
        public ActionResult New()
        {
            return View("TaskView", new TaskViewModel());
        }



        /// <summary>
        /// Go to edit task view
        /// </summary>
        public ActionResult Edit(int id)
        {
            TaskDTO task = _taskQueryService.GetTaskByID(id);

            TaskViewModel model = new TaskViewModel()
            {
                Task = task,
                ErrorMessage = task == null ? "Error - tarea no encontrada" : ""
            };

            return View("TaskView", model);
        }



        /// <summary>
        /// Go to delete task view
        /// </summary>
        public ActionResult Delete(int id)
        {
            //TaskViewModel model = new TaskViewModel()
            //{
            //    Task = _taskQueryService.GetTaskByID(id)
            //};
            //
            //return View("TaskView", model);

            throw new NotImplementedException();
        }


    }
}