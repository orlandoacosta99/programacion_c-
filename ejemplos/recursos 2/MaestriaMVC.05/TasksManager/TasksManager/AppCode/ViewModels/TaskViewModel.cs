using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasksManager.ViewModels
{
    public class TaskViewModel
    {
        public string SucessMessage { get; set; }
        public string ErrorMessage { get; set; }

        public TaskDTO Task { get; set; }
    }
}