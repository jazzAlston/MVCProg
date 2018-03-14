using MVCProg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCProg.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var cars = HelloModel.GetCars();
            
            return View(cars);
        }
        public ActionResult Contact()
        {
           
            return View();
        }
        public ActionResult About()
        {
            
            return View();
        }
    }
}