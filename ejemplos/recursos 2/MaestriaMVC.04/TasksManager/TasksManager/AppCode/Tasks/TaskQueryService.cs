using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using TasksManager.Services;



namespace TasksManager.QueryServices
{

    public class TaskQueryService
    {

        public TaskQueryService()
        {
        }


        public List<TaskDTO> GetTasks()
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Tasks().ToList();
            }

        }



        public TaskDTO GetTaskByID(int id)
        {
            using (GlobalDbContext context = new GlobalDbContext())
            {
                return context.Tasks().Where(t => t.ID == id).FirstOrDefault();
            }
        }
    }
}