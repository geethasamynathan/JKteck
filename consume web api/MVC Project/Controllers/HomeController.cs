using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using ConsumewebApiinMvcdemo.Models;
using Newtonsoft.Json;

namespace ConsumewebApiinMvcdemo.Controllers
{
    public class HomeController : Controller
    {
        IEnumerable<Employee> Employees = null;
        public ActionResult Index()
        {
           return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}