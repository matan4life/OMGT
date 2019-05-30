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
    public class MarkComparer : IEqualityComparer<Mark>
    {
        public bool Equals(Mark x, Mark y)
        {
            return x.NumericMark == y.NumericMark || x.Name == y.Name;
        }

        public int GetHashCode(Mark obj)
        {
            return obj.MarkId.GetHashCode() ^
                obj.NumericMark.GetHashCode() ^
                obj.Name.GetHashCode();
        }
    }
    public class MarksController : Controller
    {
        private DataContext _context = new DataContext();

        // GET: Marks
        public async Task<IActionResult> Index()
        {
            var qualitative = _context
                .Marks
                .Include(m => m.Criterion)
                .Where(x => x.Criterion.Type == Models.Enums.CriteriaType.Qualitative)
                .GroupBy(x => x.Name)
                .Select(x => x.First());

            var quantitative = _context
                .Marks
                .Include(x => x.Criterion)
                .Where(x => x.Criterion.Type == Models.Enums.CriteriaType.Quantitative)
                .GroupBy(x => x.NumericMark)
                .Select(x => x.First());
            var dataContext = qualitative.Union(quantitative);
            ViewBag.Criteria = _context.Criteria.ToList();
            return View(await dataContext.ToListAsync());
        }

        // GET: Marks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.Marks
                .Include(m => m.Criterion)
                .FirstOrDefaultAsync(m => m.MarkId == id);
            if (mark == null)
            {
                return NotFound();
            }

            return View(mark);
        }

        // GET: Marks/Create
        public IActionResult Create()
        {
            ViewData["CriterionId"] = new SelectList(_context.Criteria, "CriterionId", "CriterionId");
            return View();
        }

        // POST: Marks/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("MarkId,CriterionId,Name,Range,NumericMark,StandartizedMark")] Mark mark)
        {
            try
            {
                var value = Convert.ToInt32(Request.Form["Criterion.CriterionId"].ToString());
                mark.Criterion = _context.Criteria.FirstOrDefault(x => x.CriterionId == value);
            }
            catch { }
            if (ModelState.IsValid)
            {
                await _context.Marks.AddAsync(mark);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CriterionId"] = new SelectList(_context.Criteria, "Name", "Name", mark.CriterionId);
            return View(mark);
        }

        // GET: Marks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.Marks.FindAsync(id);
            if (mark == null)
            {
                return NotFound();
            }
            ViewData["CriterionId"] = new SelectList(_context.Criteria, "CriterionId", "CriterionId", mark.CriterionId);
            return View(mark);
        }

        // POST: Marks/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("MarkId,Name,Range,NumericMark,StandartizedMark,CriterionId")] Mark mark)
        {
            if (id != mark.MarkId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(mark);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MarkExists(mark.MarkId))
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
            ViewData["CriterionId"] = new SelectList(_context.Criteria, "CriterionId", "CriterionId", mark.CriterionId);
            return View(mark);
        }

        // GET: Marks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var mark = await _context.Marks
                .Include(m => m.Criterion)
                .FirstOrDefaultAsync(m => m.MarkId == id);
            if (mark == null)
            {
                return NotFound();
            }

            return View(mark);
        }

        // POST: Marks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mark = await _context.Marks.FindAsync(id);
            _context.Marks.Remove(mark);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MarkExists(int id)
        {
            return _context.Marks.Any(e => e.MarkId == id);
        }
    }
}
