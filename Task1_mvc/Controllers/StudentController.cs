using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task1_mvc.Models;

namespace Task1_mvc.Controllers
{
    public class StudentController : Controller
    {
        // GET: StudentControllers
        public ActionResult Index()
        {  Student mystudent = new Student();
            mystudent.Name = "Roaa";
            mystudent.Age = 22;
            mystudent.Course = "English";
            Student student = new Student() { Age = 22, Name = "roaa", Course = "IT", Id = "123444" };
            return View(student);
        }
    }
}