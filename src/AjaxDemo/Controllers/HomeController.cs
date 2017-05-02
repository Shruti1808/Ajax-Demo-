using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AjaxDemo.Models;


namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: /<controller>/ This is to View our index page initially
        public IActionResult Index()
        {
            return View();
        }

        //This is to Get our first URL SHOW from clicking on 'Hello Ajax' on the html page
        public IActionResult ShowHello()
        {
            return Content("We can literally display whatever we want here - like 'Hello Shruti!!'", "text/plain");
        }

        public IActionResult Sum(int firstNumber, int secondNumber)
        {
            return Content((firstNumber + secondNumber).ToString(), "text/plain");
        }

        public IActionResult DisplayObject()
        {
            Destination destination = new Destination("Tokyo", "Japan", 1);
            return Json(destination);
        }

        public IActionResult DisplayViewWithAjax()
        {
            return View();
        }
    }
}
