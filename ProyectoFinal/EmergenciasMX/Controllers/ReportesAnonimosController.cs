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
    public class ReportesAnonimosController : Controller
    {
        private readonly emergenciasMxContext _context;

        public ReportesAnonimosController(emergenciasMxContext context)
        {
            _context = context;
        }

        // GET: ReportesAnonimos
        public async Task<IActionResult> Index()
        {
            var emergenciasMxContext = _context.ReportesAnonimos.Include(r => r.Emergencia);
            return View(await emergenciasMxContext.ToListAsync());
        }

        // GET: ReportesAnonimos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportesAnonimos = await _context.ReportesAnonimos
                .Include(r => r.Emergencia)
                .FirstOrDefaultAsync(m => m.ReportesAnonimosId == id);
            if (reportesAnonimos == null)
            {
                return NotFound();
            }

            return View(reportesAnonimos);
        }

        // GET: ReportesAnonimos/Create
        public IActionResult Create()
        {
            ViewData["EmergenciaId"] = new SelectList(_context.Emergencia, "EmergenciaId", "Descripcion");
            return View();
        }

        // POST: ReportesAnonimos/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ReportesAnonimosId,Descripcion,EmergenciaId")] ReportesAnonimos reportesAnonimos)
        {
            if (ModelState.IsValid)
            {
                _context.Add(reportesAnonimos);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmergenciaId"] = new SelectList(_context.Emergencia, "EmergenciaId", "Descripcion", reportesAnonimos.EmergenciaId);
            return View(reportesAnonimos);
        }

        // GET: ReportesAnonimos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportesAnonimos = await _context.ReportesAnonimos.FindAsync(id);
            if (reportesAnonimos == null)
            {
                return NotFound();
            }
            ViewData["EmergenciaId"] = new SelectList(_context.Emergencia, "EmergenciaId", "Descripcion", reportesAnonimos.EmergenciaId);
            return View(reportesAnonimos);
        }

        // POST: ReportesAnonimos/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ReportesAnonimosId,Descripcion,EmergenciaId")] ReportesAnonimos reportesAnonimos)
        {
            if (id != reportesAnonimos.ReportesAnonimosId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(reportesAnonimos);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReportesAnonimosExists(reportesAnonimos.ReportesAnonimosId))
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
            ViewData["EmergenciaId"] = new SelectList(_context.Emergencia, "EmergenciaId", "Descripcion", reportesAnonimos.EmergenciaId);
            return View(reportesAnonimos);
        }

        // GET: ReportesAnonimos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var reportesAnonimos = await _context.ReportesAnonimos
                .Include(r => r.Emergencia)
                .FirstOrDefaultAsync(m => m.ReportesAnonimosId == id);
            if (reportesAnonimos == null)
            {
                return NotFound();
            }

            return View(reportesAnonimos);
        }

        // POST: ReportesAnonimos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var reportesAnonimos = await _context.ReportesAnonimos.FindAsync(id);
            _context.ReportesAnonimos.Remove(reportesAnonimos);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReportesAnonimosExists(int id)
        {
            return _context.ReportesAnonimos.Any(e => e.ReportesAnonimosId == id);
        }
    }
}
