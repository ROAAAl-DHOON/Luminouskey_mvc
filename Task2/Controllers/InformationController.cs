using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Task2.Models;

namespace Task2.Controllers
{
    public class InformationController : Controller
    {
        // GET: Information
        public ActionResult Index(int? id )
        {
           /* Information info1 = new Information();
            info1.Name = "Roa'a Al-Dhoon";
            info1.phone_number = "0782525113";
            info1.Email = "roaaaldhoun111@gmail.com";
            info1.Summary = "Passionate graduate student at Jordan University of Science and Technology (JUST), with strong programming skills in C#, C++ and Python. Have an excellent experience in web development programming using HTML, CSS, OOP, Verilog, Java Script and SQL.  ";
            info1.Education = "Jordan University of Science and Technology (JUST) | Computer Engineering \r\n•\tCumulative GPA: 3.35/4.2 (very good high)   \r\n•\tExpected Graduation: 2025 (JUN) \r\n";
            info1.Skills = "Technical Skills:\r\n-Programming Languages: C#, C++, Python, Verilog, HTML and java Script\r\n-Software Concepts: Object-Oriented Programming (OOP), Data Structures, Algorithms\r\n-Tools: Multi-threading, UML modeling\r\n-Image Processing Techniques\r\n-Database Management: SQL, PL/SQL, ORACLE\r\n";
            info1.Projects = "•\tShopping Website for books using C# language (using Asp.net).\r\n•\tShopping Website for clothes using C# language (using Asp.net).\r\n•\tGraduation Project: Application that connects to Esp programmed using Flutter language the app will send/receive data to/from the Esp using Firebase (cloud firestore) the app used for blind person in order to help him know if there is an obstacle in front of him and some other features like call emergency, send current location and know the statues of sensors.\r\n";
            info1.Languages = "-English: Fluent\r\n-Arabic: Native\r\n";
          
            return View(info1);*/
           Information info = new Information();
            var student = info.GetInfo(id);
            return View(student);
        }

    }
}