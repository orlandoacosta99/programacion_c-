using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TasksManager.Services;

namespace TasksManager.CommandServices
{
    public class TaskCommandService
    {


        public void UpdateTask(TaskDTO task)
        {

            using (GlobalDbContext context = new GlobalDbContext())
            {

                //load task from database
                TaskDTO existingTask = context.Tasks(true).Where(t => t.ID == task.ID).FirstOrDefault();

                //assign values
                existingTask.DueDate = task.DueDate;
                existingTask.Name = task.Name;

                //save changes to db
                context.SaveChanges();

            }

        }

        public void CreateTask(TaskDTO task)
        {

            using (GlobalDbContext context = new GlobalDbContext())
            {
                //assign create date
                task.CreateDate = DateTime.Now;

                //add task to context
                context.Add(task);

                //save changes to db
                context.SaveChanges();

            }
        }
    }
}