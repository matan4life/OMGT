using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OMGT_Lab1.Data;
using OMGT_Lab1.Models;

namespace OMGT_Lab1.Controllers
{
    [Authorize]
    public class MainCriteriaController : Controller
    {
        private DataContext db = new DataContext();
        public IActionResult Index()
        {
            ViewBag.Criteria = db.Criteria.OrderBy(x => x.CriterionId).ToList();
            ViewBag.Names = db.Criteria.Select(x => x.Name).ToList();
            ViewBag.State = "Initial";
            ViewBag.MainCriterion = new Criterion();
            return View(db.Alternatives.Include(x => x.Vectors).ThenInclude(x => x.Mark).ThenInclude(x => x.Criterion).ToList());
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(int id)
        {
            var status = Request.Form.FirstOrDefault(p => p.Key == "State").Value[0];
            if (status == "Initial")
            {
                foreach (var alt in db.Alternatives.Include(x => x.Vectors).ThenInclude(x => x.Mark).ThenInclude(x => x.Criterion))
                {
                    var numbers = Request.Form.FirstOrDefault(p => p.Key == alt.AlternativeName).Value;
                    int i = 0;
                    foreach (var vec in alt.Vectors.OrderBy(x => x.Mark.CriterionId))
                    {
                        if (vec.Mark.Criterion.Type == Models.Enums.CriteriaType.Qualitative)
                        {
                            vec.Mark.NumericMark = int.Parse(numbers[i++]);
                        }
                    }
                }
                Criterion MainCriterion = new Criterion();
                var value = Request.Form.FirstOrDefault(p => p.Key == "MainCriterion").Value[1];
                foreach (var c in db.Criteria)
                {
                    if (c.Name == value)
                    {
                        MainCriterion = c;
                        break;
                    }
                }
                db.SaveChanges();
                ViewBag.State = "Limitations";
                ViewBag.MainCriterion = MainCriterion;
                ViewBag.CriteriaExceptMain = db.Criteria.Except(new List<Criterion>() { MainCriterion }).ToList();
                ViewBag.Criteria = db.Criteria.OrderBy(x => x.CriterionId).ToList();
                ViewBag.Names = db.Criteria.Select(x => x.Name).ToList();
                return View(BuildParetoSet(db.Alternatives.Include(x => x.Vectors).ThenInclude(x => x.Mark).ThenInclude(x => x.Criterion).ToList()));
            }
            else if (status == "Limitations")
            {
                var main = db.Criteria
                    .Include(x => x.Marks)
                    .ThenInclude(x => x.Vectors)
                    .ThenInclude(x => x.Alternative)
                    .Where(x => x.CriterionId == int.Parse(Request.Form.FirstOrDefault(y => y.Key == "MainCriterion").Value[0]))
                    .FirstOrDefault();
                var elements = Request.Form.FirstOrDefault(p => p.Key == "Limitation").Value;
                var alts = BuildParetoSet(db.Alternatives.Include(x => x.Vectors).ThenInclude(x => x.Mark).ThenInclude(x => x.Criterion).ToList());
                var crits = db.Criteria.Except(new List<Criterion>() { main }).ToList();
                var dict = new Dictionary<Criterion, int>();
                for (int i = 0; i < crits.Count; i++)
                {
                    dict.Add(crits[i], int.Parse(elements[i]));
                }
                var temp = new List<Alternative>(alts);
                foreach (var a in alts)
                {
                    foreach (var vec in a.Vectors)
                    {
                        if (vec.Mark.CriterionId == main.CriterionId) continue;
                        if (vec.Mark.Criterion.OptimType != Models.Enums.OptimalityType.Minimum
                            && vec.Mark.NumericMark < dict[vec.Mark.Criterion])
                        {
                            temp.Remove(a);
                            break;
                        }
                        if (vec.Mark.Criterion.OptimType == Models.Enums.OptimalityType.Minimum
                            && vec.Mark.NumericMark > dict[vec.Mark.Criterion])
                        {
                            temp.Remove(a);
                            break;
                        }
                    }
                }
                var list = new List<KeyValuePair<Alternative, Mark>>();
                foreach (var a in temp)
                {
                    list.Add(new KeyValuePair<Alternative, Mark>(a, a.Vectors.Where(x => x.Mark.CriterionId == main.CriterionId).Select(x => x.Mark).FirstOrDefault()));
                }
                if (main.OptimType == Models.Enums.OptimalityType.Minimum)
                {
                    var result = list.OrderBy(x => x.Value.NumericMark).ToList();
                    ViewBag.Best = result.Select(x => x.Key).ToList();
                }
                else
                {
                    var result = list.OrderByDescending(x => x.Value.NumericMark).ToList();
                    ViewBag.Best = result.Select(x => x.Key).ToList();
                }
                var lpr = db.LPR.Where(x => x.LPRName == User.Identity.Name).FirstOrDefault();
                lpr.Results = new List<Result>();
                var previous = db.Results.Where(x => x.LPRId == lpr.LPRId);
                db.Results.RemoveRange(previous);
                foreach (var alt in ViewBag.Best)
                {
                    lpr.Results.Add(new Result()
                    {
                        LPRId = lpr.LPRId,
                        AlternativeId = alt.AlternativeId,
                        Range = ViewBag.Best.IndexOf(alt) + 1
                    });
                }
                db.SaveChanges();
                ViewBag.MainCriterion = main;
                ViewBag.Criteria = db.Criteria.OrderBy(x => x.CriterionId).ToList();
                ViewBag.State = "Result";
                return View(db.Alternatives.Include(x => x.Vectors).ThenInclude(x => x.Mark).ThenInclude(x => x.Criterion).ToList());

            }
            return null;
        }

        private List<int> ParetoCompare(Alternative a1, Alternative a2)
        {
            int greater = 0, less = 0, equal = 0;
            var marks1 = a1.Vectors.Select(x => x.Mark).ToList();
            var marks2 = a2.Vectors.Select(x => x.Mark).ToList();
            for (int i = 0; i < marks1.Count(); i++)
            {
                if (marks1[i].Criterion.OptimType != Models.Enums.OptimalityType.Minimum)
                {
                    if (marks1[i].NumericMark > marks2[i].NumericMark) greater++;
                    else if (marks1[i].NumericMark < marks2[i].NumericMark) less++;
                    else equal++;
                }
                else
                {
                    if (marks1[i].NumericMark < marks2[i].NumericMark) greater++;
                    else if (marks1[i].NumericMark > marks2[i].NumericMark) less++;
                    else equal++;
                }
            }
            return new List<int>()
            {
                greater,
                less,
                equal
            };
        }

        private bool ParetoGreaterOrEqual(List<int> CompareResults)
        {
            return (CompareResults[0] >= 0 && CompareResults[1] == 0);
        }

        private List<Alternative> BuildParetoSet(List<Alternative> input)
        {
            var ParetoSet = new List<Alternative>(input);
            foreach (Alternative a1 in ParetoSet)
            {
                foreach (Alternative a2 in ParetoSet)
                {
                    if (a1.AlternativeId != a2.AlternativeId)
                    {
                        var result = ParetoCompare(a2, a1);
                        if (ParetoGreaterOrEqual(result))
                        {
                            ParetoSet.Remove(a1);
                            return BuildParetoSet(ParetoSet);
                        }
                        result = ParetoCompare(a1, a2);
                        if (ParetoGreaterOrEqual(result))
                        {
                            ParetoSet.Remove(a2);
                            return BuildParetoSet(ParetoSet);
                        }
                    }

                }
            }
            return input;
        }
    }
}