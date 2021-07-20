using ASP.NETcore_lesson6_2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETcore_lesson6_2.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult RegisterWindow()
        {
            return View();
        }
        public IActionResult ProceedResult(string name, string surname, int age)
        {
            return View(new User() { Name = name, Surname = surname, Age = age });
        }
    }
}
