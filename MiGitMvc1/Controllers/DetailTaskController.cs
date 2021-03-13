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
        // GET: DetailTask
        public ActionResult TaskDetail(OneTask oneTask)
        {
            return View(oneTask);
        }
    }
}