using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETcore_lesson8.Controllers
{
    public class HomeController:Controller
    {
        private readonly IHostingEnvironment _appEnvironment;
        public HomeController(IHostingEnvironment appEnvironment)
        {
            _appEnvironment = appEnvironment;
        }
        public IActionResult MethForPage1()
        {
            return View();
        }
        public IActionResult MethForPage2()
        {
            return View();
        }
        public FileResult GetFile()
        {
            string path = Path.Combine(_appEnvironment.ContentRootPath, "Files/example.txt");
            FileStream stream = new FileStream(path, FileMode.Open);
            string file_type = "Application/txt";
            string file_name = "RequestFile.txt";
            return File(stream, file_type, file_name);
        }
    }
}
