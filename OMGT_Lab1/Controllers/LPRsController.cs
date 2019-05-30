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
    public class LPRsController : Controller
    {
        private DataContext _context = new DataContext();

        // GET: LPRs
        public async Task<IActionResult> Index()
        {
            return View(await _context.LPR.ToListAsync());
        }

        // GET: LPRs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lPR = await _context.LPR
                .FirstOrDefaultAsync(m => m.LPRId == id);
            if (lPR == null)
            {
                return NotFound();
            }

            return View(lPR);
        }

        // GET: LPRs/Create
        public IActionResult Create()
        {
            ViewBag.LPR = _context.LPR.Select(x=>x.LPRName).ToList();
            return View();
        }

        // POST: LPRs/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(int id)
        {
            var LPR = new LPR();
            LPR.LPRName = User.Identity.Name;
            LPR.LPRRange = int.Parse(Request.Form.FirstOrDefault(x => x.Key == "LPRRange").Value[0]);
            if (ModelState.IsValid && _context.LPR.Select(x=>x.LPRName).ToList().IndexOf(LPR.LPRName)==-1)
            {
                _context.Add(LPR);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        // GET: LPRs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lPR = await _context.LPR.FindAsync(id);
            if (lPR == null)
            {
                return NotFound();
            }
            return View(lPR);
        }

        // POST: LPRs/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("LPRId,LPRName,LPRRange")] LPR lPR)
        {
            if (id != lPR.LPRId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lPR);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LPRExists(lPR.LPRId))
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
            return View(lPR);
        }

        // GET: LPRs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lPR = await _context.LPR
                .FirstOrDefaultAsync(m => m.LPRId == id);
            if (lPR == null)
            {
                return NotFound();
            }

            return View(lPR);
        }

        // POST: LPRs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lPR = await _context.LPR.FindAsync(id);
            _context.LPR.Remove(lPR);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LPRExists(int id)
        {
            return _context.LPR.Any(e => e.LPRId == id);
        }
    }
}
