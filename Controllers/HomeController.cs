using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SICORA.Models;

namespace SICORA.Controllers
{
    public class HomeController : Controller
    {
        private readonly MvcContext _context;

        public HomeController(MvcContext context)
        {
            _context = context;
        }


        // GET: PRUEBA
        public async Task<IActionResult> Prueba_bd(string searchString)
        {
              var prueba_bd = from m in _context.Prueba_bd select m;

             if (!String.IsNullOrEmpty(searchString))
             {
                 prueba_bd = prueba_bd.Where(s => s.Nom_juego.Contains(searchString));
             }
             
             return View(await prueba_bd.ToListAsync());

            return View(await _context.Prueba_bd.ToListAsync());
        }

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

