using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ExamenParcial2.Data;
using ExamenParcial2.Models;

namespace ExamenParcial2.Controllers
{
    public class CustumersController : Controller
    {
        private readonly Examen2Contex _context;

        public CustumersController(Examen2Contex context)
        {
            _context = context;
        }

        // GET: Custumers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Custumers.ToListAsync());
        }

        // GET: Custumers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custumers = await _context.Custumers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (custumers == null)
            {
                return NotFound();
            }

            return View(custumers);
        }

        // GET: Custumers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Custumers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,CustomerTile,CustomerForenames,CustomerSurnames,CustomerDOB,CustomerAddressStreet,CustomerAddressTown,CustomerAddressSCountry,CustomerAddressPostalCode,CustomerContactPhone,CustomerWorkPhone,CustomerMobibletPhone,ContactEmailAddress")] Custumers custumers)
        {
            if (ModelState.IsValid)
            {
                _context.Add(custumers);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(custumers);
        }

        // GET: Custumers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custumers = await _context.Custumers.FindAsync(id);
            if (custumers == null)
            {
                return NotFound();
            }
            return View(custumers);
        }

        // POST: Custumers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CustomerId,CustomerTile,CustomerForenames,CustomerSurnames,CustomerDOB,CustomerAddressStreet,CustomerAddressTown,CustomerAddressSCountry,CustomerAddressPostalCode,CustomerContactPhone,CustomerWorkPhone,CustomerMobibletPhone,ContactEmailAddress")] Custumers custumers)
        {
            if (id != custumers.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(custumers);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustumersExists(custumers.CustomerId))
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
            return View(custumers);
        }

        // GET: Custumers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var custumers = await _context.Custumers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (custumers == null)
            {
                return NotFound();
            }

            return View(custumers);
        }

        // POST: Custumers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var custumers = await _context.Custumers.FindAsync(id);
            _context.Custumers.Remove(custumers);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CustumersExists(int id)
        {
            return _context.Custumers.Any(e => e.CustomerId == id);
        }
    }
}
