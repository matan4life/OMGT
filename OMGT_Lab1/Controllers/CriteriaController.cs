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
    public class CriteriaController : Controller
    {
        private DataContext _context = new DataContext();

        // GET: Criteria
        public async Task<IActionResult> Index()
        {
            return View(await _context.Criteria.ToListAsync());
        }

        // GET: Criteria/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var criterion = await _context.Criteria
                .FirstOrDefaultAsync(m => m.CriterionId == id);
            if (criterion == null)
            {
                return NotFound();
            }

            return View(criterion);
        }

        // GET: Criteria/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Criteria/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Criterion l)
        {
            Criterion criterion = new Criterion();
            criterion.Name = Request.Form.FirstOrDefault(p => p.Key == "Name").Value;
            criterion.Range = 0;
            criterion.Weight = 0;
            var type = Request.Form.FirstOrDefault(p=>p.Key=="Type").Value[0];
            criterion.Type = (type == "Quantitative") ? Models.Enums.CriteriaType.Quantitative : Models.Enums.CriteriaType.Qualitative;
            var optimType = (Request.Form.FirstOrDefault(p => p.Key == "OptimalityType").Value[0]);
            criterion.OptimType = (optimType == "None") ? Models.Enums.OptimalityType.None : (optimType == "Maximum") ? Models.Enums.OptimalityType.Maximum : Models.Enums.OptimalityType.Minimum;
            var unit = (Request.Form.FirstOrDefault(p => p.Key == "Units").Value[0]);
            switch (unit)
            {
                case "None":
                    criterion.Unit = Models.Enums.Units.None;
                    break;
                case "USD":
                    criterion.Unit = Models.Enums.Units.USD;
                    break;
                case "year":
                    criterion.Unit = Models.Enums.Units.year;
                    break;
                case "m":
                    criterion.Unit = Models.Enums.Units.m;
                    break;
                case "km":
                    criterion.Unit = Models.Enums.Units.km;
                    break;
                case "kg":
                    criterion.Unit = Models.Enums.Units.kg;
                    break;
                case "Liter":
                    criterion.Unit = Models.Enums.Units.Liter;
                    break;
                case "kmPerHour":
                    criterion.Unit = Models.Enums.Units.kmPerHour;
                    break;
                case "hp":
                    criterion.Unit = Models.Enums.Units.hp;
                    break;
                case "second":
                    criterion.Unit = Models.Enums.Units.second;
                    break;
                case "litersPer100Km":
                    criterion.Unit = Models.Enums.Units.litersPer100Km;
                    break;
                case "mm":
                    criterion.Unit = Models.Enums.Units.mm;
                    break;
            }
            switch (Request.Form.FirstOrDefault(p => p.Key == "ScaleTypes").Value[0])
            {
                case "Nominal":
                    criterion.ScaleType = Models.Enums.ScaleTypes.Nominal;
                    break;
                case "Interval":
                    criterion.ScaleType = Models.Enums.ScaleTypes.Interval;
                    break;
                case "Ordinal":
                    criterion.ScaleType = Models.Enums.ScaleTypes.Ordinal;
                    break;
                case "Relation":
                    criterion.ScaleType = Models.Enums.ScaleTypes.Relation;
                    break;
                case "Difference":
                    criterion.ScaleType = Models.Enums.ScaleTypes.Difference;
                    break;
                case "Absolute":
                    criterion.ScaleType = Models.Enums.ScaleTypes.Absolute;
                    break;
            }
            if (ModelState.IsValid)
            {
                _context.Add(criterion);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(criterion);
        }

        // GET: Criteria/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var criterion = await _context.Criteria.FindAsync(id);
            if (criterion == null)
            {
                return NotFound();
            }
            return View(criterion);
        }

        // POST: Criteria/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CriterionId,Name,Type,OptimType,Unit,ScaleType")] Criterion criterion)
        {
            if (id != criterion.CriterionId)
            {
                return NotFound();
            }
            criterion.Name = Request.Form.FirstOrDefault(p => p.Key == "Name").Value;
            criterion.Range = 0;
            criterion.Weight = 0;
            var type = Request.Form.FirstOrDefault(p => p.Key == "Type").Value[0];
            criterion.Type = (type == "Quantitative") ? Models.Enums.CriteriaType.Quantitative : Models.Enums.CriteriaType.Qualitative;
            var optimType = (Request.Form.FirstOrDefault(p => p.Key == "OptimalityType").Value[0]);
            criterion.OptimType = (optimType == "None") ? Models.Enums.OptimalityType.None : (optimType == "Maximum") ? Models.Enums.OptimalityType.Maximum : Models.Enums.OptimalityType.Minimum;
            var unit = (Request.Form.FirstOrDefault(p => p.Key == "Units").Value[0]);
            switch (unit)
            {
                case "None":
                    criterion.Unit = Models.Enums.Units.None;
                    break;
                case "USD":
                    criterion.Unit = Models.Enums.Units.USD;
                    break;
                case "year":
                    criterion.Unit = Models.Enums.Units.year;
                    break;
                case "m":
                    criterion.Unit = Models.Enums.Units.m;
                    break;
                case "km":
                    criterion.Unit = Models.Enums.Units.km;
                    break;
                case "kg":
                    criterion.Unit = Models.Enums.Units.kg;
                    break;
                case "Liter":
                    criterion.Unit = Models.Enums.Units.Liter;
                    break;
                case "kmPerHour":
                    criterion.Unit = Models.Enums.Units.kmPerHour;
                    break;
                case "hp":
                    criterion.Unit = Models.Enums.Units.hp;
                    break;
                case "second":
                    criterion.Unit = Models.Enums.Units.second;
                    break;
                case "litersPer100Km":
                    criterion.Unit = Models.Enums.Units.litersPer100Km;
                    break;
                case "mm":
                    criterion.Unit = Models.Enums.Units.mm;
                    break;
            }
            switch (Request.Form.FirstOrDefault(p => p.Key == "ScaleTypes").Value[0])
            {
                case "Nominal":
                    criterion.ScaleType = Models.Enums.ScaleTypes.Nominal;
                    break;
                case "Interval":
                    criterion.ScaleType = Models.Enums.ScaleTypes.Interval;
                    break;
                case "Ordinal":
                    criterion.ScaleType = Models.Enums.ScaleTypes.Ordinal;
                    break;
                case "Relation":
                    criterion.ScaleType = Models.Enums.ScaleTypes.Relation;
                    break;
                case "Difference":
                    criterion.ScaleType = Models.Enums.ScaleTypes.Difference;
                    break;
                case "Absolute":
                    criterion.ScaleType = Models.Enums.ScaleTypes.Absolute;
                    break;
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(criterion);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CriterionExists(criterion.CriterionId))
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
            return View(criterion);
        }

        // GET: Criteria/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var criterion = await _context.Criteria
                .FirstOrDefaultAsync(m => m.CriterionId == id);
            if (criterion == null)
            {
                return NotFound();
            }

            return View(criterion);
        }

        // POST: Criteria/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var criterion = await _context.Criteria.FindAsync(id);
            _context.Criteria.Remove(criterion);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CriterionExists(int id)
        {
            return _context.Criteria.Any(e => e.CriterionId == id);
        }
    }
}
