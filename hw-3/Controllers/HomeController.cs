using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hw_3.Models;
using Microsoft.AspNetCore.Mvc;


namespace hw_3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "MIA Events, Inc.";
            ViewData["From"] = "";
            ViewData["Email"] = "";
            ViewData["Body"] = "";
            return View();   
        }

        [HttpPost]
        public IActionResult Contact(Message message)
        {
            ViewData["Message"] = "MIA Events, Inc.";
            ViewData["From"] = message.from;
            ViewData["From"] = message.email;
            ViewData["Body"] = message.body;
            return View();   
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
