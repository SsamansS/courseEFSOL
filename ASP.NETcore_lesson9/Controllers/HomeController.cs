using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETcore_lesson9.Controllers
{
    [Route("api/[controller]")]
    public class HomeController:Controller
    {
        [HttpGet]
        public IActionResult GetRequest()
        {
            return View();
        }
    }
}
