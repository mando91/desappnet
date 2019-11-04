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
    public class GuestsController : Controller
    {
        private readonly Examen2Contex _context;

        public GuestsController(Examen2Contex context)
        {
            _context = context;
        }

        // GET: Guests
        public async Task<IActionResult> Index()
        {
            return View(await _context.Guests.ToListAsync());
        }

        // GET: Guests/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guests = await _context.Guests
                .FirstOrDefaultAsync(m => m.GuestId == id);
            if (guests == null)
            {
                return NotFound();
            }

            return View(guests);
        }

        // GET: Guests/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Guests/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GuestId,GuestTile,GuestForenames,GuestSurnames,GuestsDOB,GuestAddressStreet,GuestAddressTown,GuestAddressSCountry,GuestAddressPostalCode,GuestContactPhone")] Guests guests)
        {
            if (ModelState.IsValid)
            {
                _context.Add(guests);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(guests);
        }

        // GET: Guests/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guests = await _context.Guests.FindAsync(id);
            if (guests == null)
            {
                return NotFound();
            }
            return View(guests);
        }

        // POST: Guests/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GuestId,GuestTile,GuestForenames,GuestSurnames,GuestsDOB,GuestAddressStreet,GuestAddressTown,GuestAddressSCountry,GuestAddressPostalCode,GuestContactPhone")] Guests guests)
        {
            if (id != guests.GuestId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(guests);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GuestsExists(guests.GuestId))
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
            return View(guests);
        }

        // GET: Guests/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var guests = await _context.Guests
                .FirstOrDefaultAsync(m => m.GuestId == id);
            if (guests == null)
            {
                return NotFound();
            }

            return View(guests);
        }

        // POST: Guests/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var guests = await _context.Guests.FindAsync(id);
            _context.Guests.Remove(guests);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GuestsExists(int id)
        {
            return _context.Guests.Any(e => e.GuestId == id);
        }
    }
}
