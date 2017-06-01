using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using hw_3.Models;
using Microsoft.AspNetCore.Mvc;

namespace hw_3.Controllers
{
    public class PartyInfoController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Guest List";
            ViewData["guestName"] = "";
            ViewData["guestPhone"] = "";
            return View();   
        }

        [HttpPost]
        public IActionResult Index(partyInfo guests)
        {
            ViewData["Message"] = "Guest List";
            ViewData["guestName"] = guests.guestName;
            ViewData["guestPhone"] = guests.guestPhone;
            return View();   
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}