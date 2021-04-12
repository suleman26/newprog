using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dutch_retreat.Controllers
{
    public class AppController:Controller
    {
        public IActionResult Index()
        {
            //throw new InvalidProgramException("Ops We will fix it");
            return View();
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Tittle = "Contact us";
            throw new InvalidOperationException();

            return View();

           
        }

        public IActionResult About()
        {
            ViewBag.Tittle = "About us";

            return View();
        }
    }
}
