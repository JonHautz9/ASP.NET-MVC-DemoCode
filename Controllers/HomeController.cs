using HelloMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloMVC.Controllers                      //ASP.NET MVC by default uses convention over configuration to provide productive workflow
{
    public class HomeController : Controller        //ASP.NET engine looks for controller with name 'Home', the controller has to have the suffix 'Controller'
    {
        public ActionResult Index()                 //ASP.NET engine also looks for action result called 'Index'
        {
            ViewBag.Value = "This message is coming straight from the Action method";

            var cars = HelloModel.GetCars();        //Accesses the Model class

            return View(cars);                      //Returns an instance of the list of cars to the view
        }
    }
}