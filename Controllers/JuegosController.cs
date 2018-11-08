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
    public class JuegosController : Controller
    {
        private readonly MvcContext _context;

        public JuegosController(MvcContext context)
        {
            _context = context;
        }
        public IActionResult Mostrar_juegos()
        {
            return View();
        } 
        public IActionResult Agregar_juegos()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Agregar_juegos([Bind("Nom_juego, Desc_juego, trailer_juego, Img_juego, Pre_juego")] Juegos juegos)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(juegos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Mostrar_juegos));
            }
            return View(juegos);
        }

    }
}