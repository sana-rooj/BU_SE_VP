using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            Student obj = new Student();
            obj.InitializeStudent();
            return View(obj);
        }

        public ActionResult Show()
        {
            Student obj = new Student();
            obj.InitializeStudent();
            return View(obj);
        }
    }
}