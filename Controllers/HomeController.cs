using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SICORA.Models;

namespace SICORA.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Principal()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult Prueba_bd()
        {
            return View();
        }
        
    }
}

