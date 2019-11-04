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
    public class RoomsController : Controller
    {
        private readonly Examen2Contex _context;

        public RoomsController(Examen2Contex context)
        {
            _context = context;
        }

        // GET: Rooms
        public async Task<IActionResult> Index()
        {
            var examen2Contex = _context.Rooms.Include(r => r.RoomBands).Include(r => r.RoomPrices).Include(r => r.RoomTypes);
            return View(await examen2Contex.ToListAsync());
        }

        // GET: Rooms/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rooms = await _context.Rooms
                .Include(r => r.RoomBands)
                .Include(r => r.RoomPrices)
                .Include(r => r.RoomTypes)
                .FirstOrDefaultAsync(m => m.RoomId == id);
            if (rooms == null)
            {
                return NotFound();
            }

            return View(rooms);
        }

        // GET: Rooms/Create
        public IActionResult Create()
        {
            ViewData["RoomBandId"] = new SelectList(_context.RoomBands, "RoomBandId", "BandDesc");
            ViewData["RoomPriceId"] = new SelectList(_context.RoomPrices, "RoomPriceId", "RoomPriceId");
            ViewData["RoomTypeId"] = new SelectList(_context.RoomTypes, "RoomTypeId", "RoomType");
            return View();
        }

        // POST: Rooms/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RoomId,Floor,AdditionalNotes,RoomBandId,RoomPriceId,RoomTypeId")] Rooms rooms)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rooms);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["RoomBandId"] = new SelectList(_context.RoomBands, "RoomBandId", "BandDesc", rooms.RoomBandId);
            ViewData["RoomPriceId"] = new SelectList(_context.RoomPrices, "RoomPriceId", "RoomPriceId", rooms.RoomPriceId);
            ViewData["RoomTypeId"] = new SelectList(_context.RoomTypes, "RoomTypeId", "RoomType", rooms.RoomTypeId);
            return View(rooms);
        }

        // GET: Rooms/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rooms = await _context.Rooms.FindAsync(id);
            if (rooms == null)
            {
                return NotFound();
            }
            ViewData["RoomBandId"] = new SelectList(_context.RoomBands, "RoomBandId", "BandDesc", rooms.RoomBandId);
            ViewData["RoomPriceId"] = new SelectList(_context.RoomPrices, "RoomPriceId", "RoomPriceId", rooms.RoomPriceId);
            ViewData["RoomTypeId"] = new SelectList(_context.RoomTypes, "RoomTypeId", "RoomType", rooms.RoomTypeId);
            return View(rooms);
        }

        // POST: Rooms/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RoomId,Floor,AdditionalNotes,RoomBandId,RoomPriceId,RoomTypeId")] Rooms rooms)
        {
            if (id != rooms.RoomId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rooms);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RoomsExists(rooms.RoomId))
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
            ViewData["RoomBandId"] = new SelectList(_context.RoomBands, "RoomBandId", "BandDesc", rooms.RoomBandId);
            ViewData["RoomPriceId"] = new SelectList(_context.RoomPrices, "RoomPriceId", "RoomPriceId", rooms.RoomPriceId);
            ViewData["RoomTypeId"] = new SelectList(_context.RoomTypes, "RoomTypeId", "RoomType", rooms.RoomTypeId);
            return View(rooms);
        }

        // GET: Rooms/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rooms = await _context.Rooms
                .Include(r => r.RoomBands)
                .Include(r => r.RoomPrices)
                .Include(r => r.RoomTypes)
                .FirstOrDefaultAsync(m => m.RoomId == id);
            if (rooms == null)
            {
                return NotFound();
            }

            return View(rooms);
        }

        // POST: Rooms/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rooms = await _context.Rooms.FindAsync(id);
            _context.Rooms.Remove(rooms);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RoomsExists(int id)
        {
            return _context.Rooms.Any(e => e.RoomId == id);
        }
    }
}
