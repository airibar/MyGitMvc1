using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MiGitMvc1.Models;
using System.Web.Mvc;

namespace MiGitMvc1.Controllers
    {
    // delelgate
    public delegate int MyDelegate();
    
    public class TobedeletedController : Controller
        {
       
        // GET: tobedeleted
        public ActionResult Index(int? id)
            {
            // models
            TestDelegateModel newDelegateModel = new TestDelegateModel();
            // delegate subscribers
            MyDelegate _myDelegateA = ClaseA.MetodoUno;
            MyDelegate _myDelegateB = ClaseB.MetodoDos;
            if (id==1)
                {
                newDelegateModel.nameDelegate = "Metodo1";
                newDelegateModel.valueDalegate = _myDelegateA();

                }
            else
                {
                newDelegateModel.nameDelegate = "Metodo2";
                newDelegateModel.valueDalegate = _myDelegateB();


                }
            return View(newDelegateModel);
            }
        }
    //class a
    public class ClaseA
        {
        public static int MetodoUno()
            {
            return 1;
            }
        }
    // end class a
    //class B
    public class ClaseB
        {
        public static int MetodoDos()
            {
            return 2;
            }
        }
    // end class B


    }