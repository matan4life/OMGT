using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OMGT_Lab1.Data;
using OMGT_Lab1.Models;

namespace OMGT_Lab1.Controllers
{
    public class VectorsController : Controller
    {
        private DataContext _context = new DataContext();
        private int? CurrentAlternative;
        // GET: Vectors
        public async Task<IActionResult> Index()
        {
            var dataContext = _context.Vectors.Include(v => v.Alternative).Include(v => v.Mark).ThenInclude(t=>t.Criterion);
            ViewBag.Alternatives = _context.Alternatives.Include(p => p.Vectors).ThenInclude(x => x.Mark).ThenInclude(t=>t.Criterion).ToList();
            return View(await dataContext.ToListAsync());
        }

        // GET: Vectors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vector = await _context.Vectors
                .Include(v => v.Alternative)
                .Include(v => v.Mark)
                .FirstOrDefaultAsync(m => m.VectorId == id);
            if (vector == null)
            {
                return NotFound();
            }

            return View(vector);
        }

        // GET: Vectors/Create
        public IActionResult Create(int? id)
        {
            if (id is null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CurrentAlternative = id;
            ViewData["AlternativeId"] = id;
            ViewData["AlternativeName"] = _context.Alternatives.Where(x => x.AlternativeId == id).Select(x => x.AlternativeName).FirstOrDefault();
            ViewData["MarkId"] = new SelectList(_context.Marks, "MarkId", "MarkId");
            ViewData["CriterionName"] = new SelectList(_context.Criteria, "Name", "Name");
            ViewBag.Marks = _context.Marks.ToList();
            ViewBag.Criteria = new List<Criterion>();
            var alternative = _context.Alternatives.Include(x => x.Vectors).ThenInclude(x => x.Mark).ThenInclude(x => x.Criterion).Where(x => x.AlternativeId == CurrentAlternative).FirstOrDefault();
            if (alternative.Vectors is null || alternative.Vectors.Count == 0) ViewBag.Criteria = _context.Criteria.ToList();
            else
            {
                var existing = new List<Criterion>();
                foreach (var vector in alternative.Vectors)
                {
                    existing.Add(vector.Mark.Criterion);
                }
                foreach (var criteria in _context.Criteria)
                {
                    if (existing.IndexOf(criteria) == -1)
                    {
                        ViewBag.Criteria.Add(criteria);
                    }
                }
            }
            return View();
        }

        // POST: Vectors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create()
        {
            var vector = new Vector();
            var AlternativeId = int.Parse(Request.Form.FirstOrDefault(p => p.Key == "AlternativeId").Value[0]);
            var currentAlternative = _context.Alternatives.Include(x => x.Vectors).ThenInclude(x => x.Mark).ThenInclude(x => x.Criterion).Where(x => x.AlternativeId == AlternativeId).FirstOrDefault();
            var NumericMarks = Request.Form.FirstOrDefault(p => p.Key == "Mark.NumericMark").Value;
            var NameMarks = Request.Form.FirstOrDefault(p => p.Key == "Mark.Name").Value;
            var existing = new List<Criterion>();
            var Criteria = new List<Criterion>();
            foreach (var vector1 in currentAlternative.Vectors)
            {
                existing.Add(vector1.Mark.Criterion);
            }
            foreach (var criteria in _context.Criteria)
            {
                if (existing.IndexOf(criteria) == -1)
                {
                    Criteria.Add(criteria);
                }
            }
            var num = 0;
            var text = 0;
            if (currentAlternative.Vectors is null)
            {
                currentAlternative.Vectors = new List<Vector>();
            }
            foreach (var el in Criteria)
            {
                if (el.Type == Models.Enums.CriteriaType.Quantitative)
                {
                    _context.Marks.Add(new Mark() { Criterion = el, NumericMark = int.Parse(NumericMarks[num++]) });
                }
                else
                {
                    _context.Marks.Add(new Mark() { Criterion = el, Name =  NameMarks[text++]});
                }
                _context.SaveChanges();
                currentAlternative.Vectors.Add(new Vector() { AlternativeId = currentAlternative.AlternativeId, MarkId = _context.Marks.Last().MarkId });
            }
            if (ModelState.IsValid)
            {
                _context.Update(currentAlternative);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AlternativeId"] = new SelectList(_context.Alternatives, "AlternativeId", "AlternativeId", vector.AlternativeId);
            ViewData["MarkId"] = new SelectList(_context.Marks, "MarkId", "MarkId", vector.MarkId);
            return View(vector);
        }

        // GET: Vectors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }


            var vector = await _context.Vectors.Include(x => x.Alternative).Include(x => x.Mark).ThenInclude(x => x.Criterion).Where(x => x.VectorId == id).FirstOrDefaultAsync();
            ViewData["Alternative"] = vector.Alternative.AlternativeName;
            ViewData["Criterion"] = vector.Mark.Criterion.Name;
            if (vector == null)
            {
                return NotFound();
            }
            ViewBag.Alternatives = new SelectList(_context.Alternatives.Select(x => x.AlternativeName).ToList());
            ViewData["MarkId"] = new SelectList(_context.Marks, "MarkId", "MarkId", vector.MarkId);
            return View(vector);
        }

        // POST: Vectors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit()
        {
            var vector = _context.Vectors.Include(x => x.Alternative).Include(x => x.Mark).ThenInclude(x => x.Criterion).Where(x => x.VectorId == int.Parse(Request.Form.FirstOrDefault(p => p.Key == "VectorId").Value[0])).FirstOrDefault();
            if (vector.Mark.Criterion.Type == Models.Enums.CriteriaType.Quantitative)
            {

                vector.Mark.NumericMark=int.Parse(Request.Form.FirstOrDefault(p=>p.Key=="Mark.NumericMark").Value[0]);
            }
            else
            {
                vector.Mark.Name = Request.Form.FirstOrDefault(p => p.Key == "Mark.Name").Value[0];
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vector);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VectorExists(vector.VectorId))
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
            ViewData["AlternativeId"] = new SelectList(_context.Alternatives, "AlternativeId", "AlternativeId", vector.AlternativeId);
            ViewData["MarkId"] = new SelectList(_context.Marks, "MarkId", "MarkId", vector.MarkId);
            return View(vector);
        }

        // GET: Vectors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var vector = await _context.Vectors
                .Include(v => v.Alternative)
                .Include(v => v.Mark)
                .ThenInclude(v=>v.Criterion)
                .FirstOrDefaultAsync(m => m.VectorId == id);
            if (vector == null)
            {
                return NotFound();
            }

            return View(vector);
        }

        // POST: Vectors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vector = await _context.Vectors.Include(x => x.Mark).Where(x => x.VectorId == id).FirstOrDefaultAsync();
            var mark = vector.Mark;
            _context.Vectors.Remove(vector);
            _context.Marks.Remove(mark);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VectorExists(int id)
        {
            return _context.Vectors.Any(e => e.VectorId == id);
        }
    }
}
