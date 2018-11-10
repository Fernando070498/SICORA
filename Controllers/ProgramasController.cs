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
    public class ProgramasController : Controller
    {   
        private readonly MvcContext _context;

        public ProgramasController(MvcContext context)
        {
            _context = context;
        }
       public async Task<IActionResult> Mostrar_Programas(string searchString)
        {
              var programa = from m in _context.Programas select m;

             if (!String.IsNullOrEmpty(searchString))
             {
                 programa = programa.Where(s => s.Nom_programa.Contains(searchString));
             }
             
             return View(await programa.ToListAsync());

            // return View(await _context.Prueba_bd.ToListAsync());
        }
        public IActionResult Agregar_Programas()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Agregar_Programas([Bind("Nom_programa, Desc_programa, Img_programa, pre_programa")] Programas programas)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(programas);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Mostrar_Programas));
            }
            return View(programas);
        }
         public async Task<IActionResult> Delete_Pro(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var programas = await _context.Programas
                .SingleOrDefaultAsync(m => m.ID == id);
            if (programas == null)
            {
                return NotFound();
            }

            return View(programas);
        }

        // POST: Movies/Delete/5
        [HttpPost, ActionName("Delete_Pro")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var programas = await _context.Programas.SingleOrDefaultAsync(m => m.ID == id);
            _context.Programas.Remove(programas);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Mostrar_Programas));
        }

        private bool MovieExists(int id)
        {
            return _context.Programas.Any(e => e.ID == id);
        }


    }
}