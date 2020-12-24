using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SimpleAppWithEmptyTemplate1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["message"] = "Message1 from the controller";
            return View();
        }
    }
}
