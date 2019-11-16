using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EmergenciasMX.Areas.Identity.Data;
using EmergenciasMX.Models;

namespace EmergenciasMX.Controllers
{
    public class InstitucionPublicaController : Controller
    {
        private readonly emergenciasMxContext _context;

        public InstitucionPublicaController(emergenciasMxContext context)
        {
            _context = context;
        }

        // GET: InstitucionPublica
        public async Task<IActionResult> Index()
        {
            return View(await _context.InstitucionPublica.ToListAsync());
        }

        // GET: InstitucionPublica/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var institucionPublica = await _context.InstitucionPublica
                .FirstOrDefaultAsync(m => m.InstitucionPublicaId == id);
            if (institucionPublica == null)
            {
                return NotFound();
            }

            return View(institucionPublica);
        }

        // GET: InstitucionPublica/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InstitucionPublica/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("InstitucionPublicaId,Nombre,NumeroIP,Estado,Municipio,Pais")] InstitucionPublica institucionPublica)
        {
            if (ModelState.IsValid)
            {
                _context.Add(institucionPublica);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(institucionPublica);
        }

        // GET: InstitucionPublica/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var institucionPublica = await _context.InstitucionPublica.FindAsync(id);
            if (institucionPublica == null)
            {
                return NotFound();
            }
            return View(institucionPublica);
        }

        // POST: InstitucionPublica/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("InstitucionPublicaId,Nombre,NumeroIP,Estado,Municipio,Pais")] InstitucionPublica institucionPublica)
        {
            if (id != institucionPublica.InstitucionPublicaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(institucionPublica);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InstitucionPublicaExists(institucionPublica.InstitucionPublicaId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(institucionPublica);
        }

        // GET: InstitucionPublica/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var institucionPublica = await _context.InstitucionPublica
                .FirstOrDefaultAsync(m => m.InstitucionPublicaId == id);
            if (institucionPublica == null)
            {
                return NotFound();
            }

            return View(institucionPublica);
        }

        // POST: InstitucionPublica/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var institucionPublica = await _context.InstitucionPublica.FindAsync(id);
            _context.InstitucionPublica.Remove(institucionPublica);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InstitucionPublicaExists(int id)
        {
            return _context.InstitucionPublica.Any(e => e.InstitucionPublicaId == id);
        }
    }
}
