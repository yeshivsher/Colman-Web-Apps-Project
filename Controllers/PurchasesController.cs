using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Colman_Final_Web_Project.Data;
using Colman_Final_Web_Project.Models;

namespace Colman_Final_Web_Project.Controllers
{
    public class PurchasesController : Controller
    {
        private readonly Context _context;

        public PurchasesController(Context context)
        {
            _context = context;
        }

        // GET: Purchases
        public async Task<IActionResult> Index()
        {
            return View(await _context.Purchases.ToListAsync());
        }

        // GET: Purchases/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchases = await _context.Purchases
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchases == null)
            {
                return NotFound();
            }

            return View(purchases);
        }

        // GET: Purchases/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Purchases/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ProductId,Price,CustomerId,Date")] Purchases purchases)
        {
            if (ModelState.IsValid)
            {
                _context.Add(purchases);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(purchases);
        }

        // GET: Purchases/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchases = await _context.Purchases.FindAsync(id);
            if (purchases == null)
            {
                return NotFound();
            }
            return View(purchases);
        }

        // POST: Purchases/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ProductId,Price,CustomerId,Date")] Purchases purchases)
        {
            if (id != purchases.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(purchases);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PurchasesExists(purchases.Id))
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
            return View(purchases);
        }

        // GET: Purchases/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var purchases = await _context.Purchases
                .FirstOrDefaultAsync(m => m.Id == id);
            if (purchases == null)
            {
                return NotFound();
            }

            return View(purchases);
        }

        // POST: Purchases/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var purchases = await _context.Purchases.FindAsync(id);
            _context.Purchases.Remove(purchases);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PurchasesExists(int id)
        {
            return _context.Purchases.Any(e => e.Id == id);
        }
    }
}
