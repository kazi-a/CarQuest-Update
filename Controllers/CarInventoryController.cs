using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CarQuest.Models;

namespace CarQuest.Controllers
{
    public class CarInventoryController : Controller
    {
        private readonly CustomerContext _context;

        public CarInventoryController(CustomerContext context)
        {
            _context = context;
        }

        // GET: CarInventory
        public async Task<IActionResult> Index()
        {
            var customerContext = _context.CarInventories.Include(c => c.Customer);
            return View(await customerContext.ToListAsync());
        }

        // GET: CarInventory/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.CarInventories == null)
            {
                return NotFound();
            }

            var carInventory = await _context.CarInventories
                .Include(c => c.Customer)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (carInventory == null)
            {
                return NotFound();
            }

            return View(carInventory);
        }

        // GET: CarInventory/Create
        public IActionResult Create()
        {
            ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "FirstName");
            return View();
        }

        // POST: CarInventory/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Make,Model,Year,CustomerID")] CarInventory carInventory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(carInventory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "FirstName", carInventory.CustomerID);
            return View(carInventory);
        }

        // GET: CarInventory/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.CarInventories == null)
            {
                return NotFound();
            }

            var carInventory = await _context.CarInventories.FindAsync(id);
            if (carInventory == null)
            {
                return NotFound();
            }
            ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "FirstName", carInventory.CustomerID);
            return View(carInventory);
        }

        // POST: CarInventory/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Make,Model,Year,CustomerID")] CarInventory carInventory)
        {
            if (id != carInventory.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(carInventory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CarInventoryExists(carInventory.ID))
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
            ViewData["CustomerID"] = new SelectList(_context.Customers, "ID", "FirstName", carInventory.CustomerID);
            return View(carInventory);
        }

        // GET: CarInventory/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.CarInventories == null)
            {
                return NotFound();
            }

            var carInventory = await _context.CarInventories
                .Include(c => c.Customer)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (carInventory == null)
            {
                return NotFound();
            }

            return View(carInventory);
        }

        // POST: CarInventory/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.CarInventories == null)
            {
                return Problem("Entity set 'CustomerContext.CarInventories'  is null.");
            }
            var carInventory = await _context.CarInventories.FindAsync(id);
            if (carInventory != null)
            {
                _context.CarInventories.Remove(carInventory);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CarInventoryExists(int id)
        {
          return (_context.CarInventories?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
