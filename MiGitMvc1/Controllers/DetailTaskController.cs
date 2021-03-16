using MiGitMvc1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiGitMvc1.Controllers
{
    public class DetailTaskController : Controller
    {
        private ApplicationDbContext _dbContext;
        public DetailTaskController()
            {
            _dbContext = new ApplicationDbContext();
            }
        // GET: DetailTask
        [HttpGet]
        public ActionResult TaskDetail(int id)
        {
            
            OneTask oneTask = new OneTask();
            oneTask = _dbContext.OneTasks.Find(id);
            if (oneTask.Title.Length > 0)
                {
                ViewBag.accion = "Update";
                }
            else
                {
                ViewBag.accion = "Create";
                }
            return View(oneTask);
        }
        [HttpPost]
        public ActionResult TaskDetail(OneTask oneTask)
            {
            using (var db = _dbContext)
                {
                OneTask task = db.OneTasks.Find(oneTask.Id);
                task.Id = oneTask.Id;
                task.Title = oneTask.Title;
                task.Description = oneTask.Description;
                task.DueDate = oneTask.DueDate;
                db.GetValidationErrors();
                db.SaveChanges();
                }


            return Redirect("/TheTask");
            }
        [HttpGet]
        public ActionResult AddTask(int? id)
            {
            return View();
            }
        [HttpGet]
        public ActionResult TaskDel(int? id)
            {
            using (var db = _dbContext)
                {
                OneTask oneTask = new OneTask();
                oneTask = db.OneTasks.Find(id);
                db.OneTasks.Remove(oneTask);
                db.SaveChanges();
                }


            return Redirect("/TheTask");
            }
        [HttpPost]
        public ActionResult AddTask(OneTask oneTask)
            {
            using (var db =_dbContext)
                {
                oneTask.DateCreation = DateTime.Now;
                var task = db.OneTasks.Add(oneTask);
                db.GetValidationErrors();
                db.SaveChanges();
                }
                         


            return Redirect("/TheTask");
            }
        }
}