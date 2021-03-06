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
        public async Task<IActionResult> Mostrar_juegos(string searchString)
        {
              var juego = from m in _context.Juegos select m;

             if (!String.IsNullOrEmpty(searchString))
             {
                 juego = juego.Where(s => s.Nom_juego.Contains(searchString));
             }
             
             return View(await juego.ToListAsync());

            // return View(await _context.Prueba_bd.ToListAsync());
        }
        public IActionResult Agregar_juegos()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Agregar_juegos([Bind("Nom_juego, Desc_juego, trailer_juego, Img_juego, pre_juego")] Juegos juegos)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(juegos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Mostrar_juegos));
            }
            return View(juegos);
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var juegos = await _context.Juegos
                .SingleOrDefaultAsync(m => m.ID == id);
            if (juegos == null)
            {
                return NotFound();
            }

            return View(juegos);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var juegos = await _context.Juegos.SingleOrDefaultAsync(m => m.ID == id);
            _context.Juegos.Remove(juegos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Mostrar_juegos));
        }

        private bool MovieExists(int id)
        {
            return _context.Juegos.Any(e => e.ID == id);
        }

    }
}