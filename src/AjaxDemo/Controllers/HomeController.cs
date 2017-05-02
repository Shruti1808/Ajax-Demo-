using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

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
    }
}
