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
    public class EmergenciaInstitucionController : Controller
    {
        private readonly emergenciasMxContext _context;

        public EmergenciaInstitucionController(emergenciasMxContext context)
        {
            _context = context;
        }

        // GET: EmergenciaInstitucion
        public async Task<IActionResult> Index()
        {
            var emergenciasMxContext = _context.EmergenciaInstitucion.Include(e => e.Emergencia).Include(e => e.InstitucionPublica);
            return View(await emergenciasMxContext.ToListAsync());
        }

        // GET: EmergenciaInstitucion/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergenciaInstitucion = await _context.EmergenciaInstitucion
                .Include(e => e.Emergencia)
                .Include(e => e.InstitucionPublica)
                .FirstOrDefaultAsync(m => m.EmergenciaInstitucionId == id);
            if (emergenciaInstitucion == null)
            {
                return NotFound();
            }

            return View(emergenciaInstitucion);
        }

        // GET: EmergenciaInstitucion/Create
        public IActionResult Create()
        {
            ViewData["EmergenciaId"] = new SelectList(_context.Emergencia, "EmergenciaId", "Descripcion");
            ViewData["InstitucionPublicaId"] = new SelectList(_context.InstitucionPublica, "InstitucionPublicaId", "Estado");
            return View();
        }

        // POST: EmergenciaInstitucion/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmergenciaInstitucionId,EmergenciaId,InstitucionPublicaId")] EmergenciaInstitucion emergenciaInstitucion)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emergenciaInstitucion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmergenciaId"] = new SelectList(_context.Emergencia, "EmergenciaId", "Descripcion", emergenciaInstitucion.EmergenciaId);
            ViewData["InstitucionPublicaId"] = new SelectList(_context.InstitucionPublica, "InstitucionPublicaId", "Estado", emergenciaInstitucion.InstitucionPublicaId);
            return View(emergenciaInstitucion);
        }

        // GET: EmergenciaInstitucion/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergenciaInstitucion = await _context.EmergenciaInstitucion.FindAsync(id);
            if (emergenciaInstitucion == null)
            {
                return NotFound();
            }
            ViewData["EmergenciaId"] = new SelectList(_context.Emergencia, "EmergenciaId", "Descripcion", emergenciaInstitucion.EmergenciaId);
            ViewData["InstitucionPublicaId"] = new SelectList(_context.InstitucionPublica, "InstitucionPublicaId", "Estado", emergenciaInstitucion.InstitucionPublicaId);
            return View(emergenciaInstitucion);
        }

        // POST: EmergenciaInstitucion/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmergenciaInstitucionId,EmergenciaId,InstitucionPublicaId")] EmergenciaInstitucion emergenciaInstitucion)
        {
            if (id != emergenciaInstitucion.EmergenciaInstitucionId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emergenciaInstitucion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmergenciaInstitucionExists(emergenciaInstitucion.EmergenciaInstitucionId))
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
            ViewData["EmergenciaId"] = new SelectList(_context.Emergencia, "EmergenciaId", "Descripcion", emergenciaInstitucion.EmergenciaId);
            ViewData["InstitucionPublicaId"] = new SelectList(_context.InstitucionPublica, "InstitucionPublicaId", "Estado", emergenciaInstitucion.InstitucionPublicaId);
            return View(emergenciaInstitucion);
        }

        // GET: EmergenciaInstitucion/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergenciaInstitucion = await _context.EmergenciaInstitucion
                .Include(e => e.Emergencia)
                .Include(e => e.InstitucionPublica)
                .FirstOrDefaultAsync(m => m.EmergenciaInstitucionId == id);
            if (emergenciaInstitucion == null)
            {
                return NotFound();
            }

            return View(emergenciaInstitucion);
        }

        // POST: EmergenciaInstitucion/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emergenciaInstitucion = await _context.EmergenciaInstitucion.FindAsync(id);
            _context.EmergenciaInstitucion.Remove(emergenciaInstitucion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmergenciaInstitucionExists(int id)
        {
            return _context.EmergenciaInstitucion.Any(e => e.EmergenciaInstitucionId == id);
        }
    }
}
