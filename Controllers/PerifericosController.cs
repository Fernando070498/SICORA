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
    public class PerifericosController : Controller
    {
         private readonly MvcContext _context;

        public PerifericosController(MvcContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Mostrar_Perifericos(string searchString)
        {
              var periferico = from m in _context.Perifericos select m;

             if (!String.IsNullOrEmpty(searchString))
             {
                 periferico = periferico.Where(s => s.Nom_perifericos.Contains(searchString));
             }
             
             return View(await periferico.ToListAsync());

            // return View(await _context.Prueba_bd.ToListAsync());
        }
        public IActionResult Agregar_Perifericos()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Agregar_Perifericos([Bind("Nom_perifericos, Desc_perifericos, Img_perifericos, pre_perifericos")] Perifericos perifericos)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(perifericos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Mostrar_Perifericos));
            }
            return View(perifericos);
        }

        public async Task<IActionResult> Delete_Per(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var perifericos = await _context.Perifericos
                .SingleOrDefaultAsync(m => m.ID == id);
            if (perifericos == null)
            {
                return NotFound();
            }

            return View(perifericos);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete_Per")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var perifericos = await _context.Perifericos.SingleOrDefaultAsync(m => m.ID == id);
            _context.Perifericos.Remove(perifericos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Mostrar_Perifericos));
        }

        private bool MovieExists(int id)
        {
            return _context.Perifericos.Any(e => e.ID == id);
        }

    }
}