using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


using TasksManager.CommandServices;
using TasksManager.QueryServices;
using TasksManager.ViewModels;


namespace TasksManager.Tasks
{
    public class TasksController : Controller
    {
        private TaskQueryService _taskQueryService;
        private TaskCommandService _taskCommandService;


        /// <summary>
        /// Constructor, initialize list of tasks
        /// </summary>
        public TasksController()
        {
            _taskQueryService = new TaskQueryService();
            _taskCommandService = new TaskCommandService();
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
            return View("TaskView", new TaskViewModel()
            {
                Task = new TaskDTO()
                {
                    DueDate = DateTime.Now.AddDays(1),
                }
            });
        }



        /// <summary>
        /// Go to new task view
        /// </summary>
        [HttpPost]
        public ActionResult New(TaskDTO task)
        {
            _taskCommandService.CreateTask(task);

            return RedirectToAction("Edit", new { id = task.ID, fc = 1 });
        }



        /// <summary>
        /// Go to edit task view
        /// </summary>
        public ActionResult Edit(int id, int? fc)
        {
            HttpContext context = System.Web.HttpContext.Current;

            TaskDTO task = _taskQueryService.GetTaskByID(id);

            TaskViewModel model = new TaskViewModel()
            {
                Task = task,
                ErrorMessage = task == null ? "Error - tarea no encontrada" : "",
                SucessMessage = fc.HasValue && fc.Value == 1 ? "Tarea creada correctamente" : "",
            };

            return View("TaskView", model);
        }



        /// <summary>
        /// Update an existing task
        /// </summary>
        [HttpPost]
        public ActionResult Edit(TaskDTO task)
        {
            //return the task to the user
            TaskViewModel model = new TaskViewModel()
            {
                Task = task,
            };

            //save changes

            try
            {
                _taskCommandService.UpdateTask(task);
                model.SucessMessage = "Tarea guardada correctamente";
            }
            catch(Exception ex)
            {
                model.ErrorMessage = ex.ToString();
            }



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