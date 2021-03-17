using MiGitMvc1.Models;
using MiGitMvc1.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiGitMvc1.Controllers
{
    public class TheTaskController : Controller
    {
        private ApplicationDbContext _dbContext;
        public TheTaskController()
            {
            _dbContext = new ApplicationDbContext();
            }
        // GET: Task
        public ActionResult Index()
        {
            AllTasks listTask = new AllTasks();
            foreach (var item in _dbContext.OneTasks)
                {
                if (item.Status == null)
                    {
                    listTask.TheListTask.Add(item);
                    }   
                };
            return View(listTask);
        }
    }
}