using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TasksManager;
using TasksManager.Services;

namespace TasksManager.AppCode.Tasks
{
    public class TasksController : Controller
    {
        private GlobalDbContext db = new GlobalDbContext();

        // GET: Tasks
        public ActionResult Index()
        {
            return View(db.TaskDTOes.ToList());
        }

        // GET: Tasks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskDTO taskDTO = db.TaskDTOes.Find(id);
            if (taskDTO == null)
            {
                return HttpNotFound();
            }
            return View(taskDTO);
        }

        // GET: Tasks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Tasks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Name,CreateDate,DueDate")] TaskDTO taskDTO)
        {
            if (ModelState.IsValid)
            {
                taskDTO.CreateDate = DateTime.Now;

                db.TaskDTOes.Add(taskDTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taskDTO);
        }

        // GET: Tasks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskDTO taskDTO = db.TaskDTOes.Find(id);
            if (taskDTO == null)
            {
                return HttpNotFound();
            }
            return View(taskDTO);
        }

        // POST: Tasks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Name,CreateDate,DueDate")] TaskDTO taskDTO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taskDTO).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(taskDTO);
        }

        // GET: Tasks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaskDTO taskDTO = db.TaskDTOes.Find(id);
            if (taskDTO == null)
            {
                return HttpNotFound();
            }

            TaskDeleteDTO taskDeleteDTO = new TaskDeleteDTO()
            {
                ID = taskDTO.ID,
                Name = taskDTO.Name,
                CreateDate = taskDTO.CreateDate,
                DueDate = taskDTO.DueDate
            };

            return View(taskDeleteDTO);
        }


        public JsonResult CheckTaskNameExists(string name)
        {
            bool taskNotExists = db.TaskDTOes.Where(t => t.Name == name).Count() ==  0;

            return new JsonResult()
            {
                Data = taskNotExists,
                JsonRequestBehavior = JsonRequestBehavior.AllowGet
            };
        }



        // POST: Tasks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(TaskDeleteDTO taskDeleteDTO)
        {
            if (ModelState.IsValid)
            {
                TaskDTO taskDTO = db.TaskDTOes.Find(taskDeleteDTO.ID);
                db.TaskDTOes.Remove(taskDTO);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(taskDeleteDTO);
        }



        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
