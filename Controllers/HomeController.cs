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
        public async Task<IActionResult> Prueba(string searchString)
        {
              var home = from m in _context.Prueba_bd select m;

             if (!String.IsNullOrEmpty(searchString))
             {
                 home = home.Where(s => s.Nom_juego.Contains(searchString));
             }
             
             return View(await home.ToListAsync());

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
        public IActionResult Create()
        {
            return View();
        }

         [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nom_juego")] Prueba_bd prueba_bd)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(prueba_bd);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Prueba));
            }
            return View(prueba_bd);
        }
        
    }
}

