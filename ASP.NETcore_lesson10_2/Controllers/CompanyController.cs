using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Datas;
using WebApplication8.Models;

namespace WebApplication8.Controllers
{
    public class CompanyController:Controller
    {
        public IEnumerable<Company> Index()
        {
            using (CompanyContext db = new CompanyContext())
            {
                db.Companies.Add(new Company() { CompanyName = "Google" });
                db.Companies.Add(new Company() { CompanyName = "Twitter" });
                db.Companies.Add(new Company() { CompanyName = "LinkedIn" });
                db.Companies.Add(new Company() { CompanyName = "Facebook" });
                db.Companies.Add(new Company() { CompanyName = "SpaceX" });
                db.SaveChanges();
            }

            return new CompanyContext().Companies;
        }
    }
}
