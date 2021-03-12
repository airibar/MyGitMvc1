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
        // GET: Task
        public ActionResult Index()
        {
            AllTasks listTask = new AllTasks();
            // creation sample task
            OneTask oneTask1 = new OneTask();
            OneTask oneTask2 = new OneTask();
            oneTask1.Id = 1;
            oneTask1.Title = "First Task";
            oneTask1.Description = "First Task of the project";
            oneTask1.DueDate = "01012021";
            listTask.TheListTask.Add(oneTask1);
            oneTask2.Id = 2;
            oneTask2.Title = "Second Task";
            oneTask2.Description = "Secondd Task of the project";
            oneTask2.DueDate = "01012021";
            listTask.TheListTask.Add(oneTask2);
            return View(listTask);
        }
    }
}