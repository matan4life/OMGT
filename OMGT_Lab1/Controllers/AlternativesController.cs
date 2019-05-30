using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OMGT_Lab1.Data;
using OMGT_Lab1.Models;

namespace OMGT_Lab1.Controllers
{
    public class AlternativesController : Controller
    {
        private DataContext _context=new DataContext();

        // GET: Alternatives
        public async Task<IActionResult> Index()
        {
            return View(await _context.Alternatives.ToListAsync());
        }

        // GET: Alternatives/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alternative = await _context.Alternatives
                .FirstOrDefaultAsync(m => m.AlternativeId == id);
            if (alternative == null)
            {
                return NotFound();
            }

            return View(alternative);
        }

        // GET: Alternatives/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Alternatives/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("AlternativeId,AlternativeName")] Alternative alternative)
        {
            if (ModelState.IsValid)
            {
                _context.Add(alternative);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(alternative);
        }

        // GET: Alternatives/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alternative = await _context.Alternatives.FindAsync(id);
            if (alternative == null)
            {
                return NotFound();
            }
            return View(alternative);
        }

        // POST: Alternatives/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("AlternativeId,AlternativeName")] Alternative alternative)
        {
            if (id != alternative.AlternativeId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(alternative);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlternativeExists(alternative.AlternativeId))
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
            return View(alternative);
        }

        // GET: Alternatives/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var alternative = await _context.Alternatives
                .FirstOrDefaultAsync(m => m.AlternativeId == id);
            if (alternative == null)
            {
                return NotFound();
            }

            return View(alternative);
        }

        // POST: Alternatives/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var alternative = await _context.Alternatives.FindAsync(id);
            _context.Alternatives.Remove(alternative);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AlternativeExists(int id)
        {
            return _context.Alternatives.Any(e => e.AlternativeId == id);
        }
    }
}
