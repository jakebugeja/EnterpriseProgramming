using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PresentationWebApp.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()//right click on Index to create view
        {
            return View();
        }
        public IActionResult HandleQuery(string query)
        {
            //proces query submitted from the index
            if (string.IsNullOrEmpty(query) == false)
            {
                ViewBag.Message = "Thanks for your query";
                    //pass data from the controller to the view
            }
            
            return View("Index");
        }
    }
}
