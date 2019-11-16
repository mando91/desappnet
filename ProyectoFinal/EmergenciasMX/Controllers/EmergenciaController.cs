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
    public class EmergenciaController : Controller
    {
        private readonly emergenciasMxContext _context;

        public EmergenciaController(emergenciasMxContext context)
        {
            _context = context;
        }

        // GET: Emergencia
        public async Task<IActionResult> Index()
        {
            var emergenciasMxContext = _context.Emergencia.Include(e => e.TipoEmergencia);
            return View(await emergenciasMxContext.ToListAsync());
        }

        // GET: Emergencia/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencia = await _context.Emergencia
                .Include(e => e.TipoEmergencia)
                .FirstOrDefaultAsync(m => m.EmergenciaId == id);
            if (emergencia == null)
            {
                return NotFound();
            }

            return View(emergencia);
        }

        // GET: Emergencia/Create
        public IActionResult Create()
        {
            ViewData["TipoEmergenciaId"] = new SelectList(_context.TipoEmergencia, "TipoEmergenciaId", "Desc");
            return View();
        }

        // POST: Emergencia/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("EmergenciaId,Fecha,Descripcion,Lugar,Estatus,TipoEmergenciaId")] Emergencia emergencia)
        {
            if (ModelState.IsValid)
            {
                _context.Add(emergencia);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["TipoEmergenciaId"] = new SelectList(_context.TipoEmergencia, "TipoEmergenciaId", "Desc", emergencia.TipoEmergenciaId);
            return View(emergencia);
        }

        // GET: Emergencia/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencia = await _context.Emergencia.FindAsync(id);
            if (emergencia == null)
            {
                return NotFound();
            }
            ViewData["TipoEmergenciaId"] = new SelectList(_context.TipoEmergencia, "TipoEmergenciaId", "Desc", emergencia.TipoEmergenciaId);
            return View(emergencia);
        }

        // POST: Emergencia/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("EmergenciaId,Fecha,Descripcion,Lugar,Estatus,TipoEmergenciaId")] Emergencia emergencia)
        {
            if (id != emergencia.EmergenciaId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(emergencia);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EmergenciaExists(emergencia.EmergenciaId))
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
            ViewData["TipoEmergenciaId"] = new SelectList(_context.TipoEmergencia, "TipoEmergenciaId", "Desc", emergencia.TipoEmergenciaId);
            return View(emergencia);
        }

        // GET: Emergencia/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var emergencia = await _context.Emergencia
                .Include(e => e.TipoEmergencia)
                .FirstOrDefaultAsync(m => m.EmergenciaId == id);
            if (emergencia == null)
            {
                return NotFound();
            }

            return View(emergencia);
        }

        // POST: Emergencia/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var emergencia = await _context.Emergencia.FindAsync(id);
            _context.Emergencia.Remove(emergencia);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EmergenciaExists(int id)
        {
            return _context.Emergencia.Any(e => e.EmergenciaId == id);
        }
    }
}
