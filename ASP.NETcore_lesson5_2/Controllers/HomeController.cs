using ASP.NETcore_lesson5_2.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETcore_lesson5_2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            Deputy dep = new Deputy()
            { Name = "Dastan Bekeshev", Party = "Reforma" };

            ViewData["Name"] = "Dastan Bekeshev";
            ViewData["Party"] = "Reforma";

            return View(dep);
        }
    }
}
