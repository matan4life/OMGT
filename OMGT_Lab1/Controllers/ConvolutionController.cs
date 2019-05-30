using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OMGT_Lab1.Data;
using OMGT_Lab1.Models;

namespace OMGT_Lab1.Controllers
{
    public class ConvolutionController : Controller
    {
        private DataContext db = new DataContext();
        public IActionResult Index()
        {
            var Alternatives = db.Alternatives.Include(t => t.Vectors).ThenInclude(t => t.Mark).ThenInclude(t => t.Criterion).ToList();
            ViewBag.Criteria = db.Criteria.OrderBy(x => x.CriterionId).ToList();
            return View(Alternatives);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(int id)
        {
            foreach (var alt in db.Alternatives.Include(x => x.Vectors).ThenInclude(x => x.Mark).ThenInclude(x => x.Criterion))
            {
                var values = Request.Form.FirstOrDefault(p => p.Key == alt.AlternativeName).Value;
                int i = 0;
                foreach (var vector in alt.Vectors)
                {
                    if (vector.Mark.Criterion.Type == Models.Enums.CriteriaType.Qualitative)
                    {
                        vector.Mark.NumericMark = int.Parse(values[i++]);
                    }
                }
            }
            db.SaveChanges();
            return Redirect("/Convolution/Result");
        }

        public IActionResult Result()
        {
            ViewBag.Criteria = db.Criteria.ToList();
            var alternatives = db.Alternatives.Include(x => x.Vectors).ThenInclude(x => x.Mark).ThenInclude(x => x.Criterion).ToList();
            var pareto = BuildParetoSet(alternatives);
            pareto = NormalizeMaxMin(pareto);
            var winner = MaximinimumConvolution(pareto);
            ViewBag.Winner = winner;
            return View(pareto);
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

        private List<Alternative> NormalizeMaxMin(List<Alternative> alternatives)
        {
            foreach (var crit in db.Criteria.ToList())
            {
                var Marks = new List<Mark>();
                foreach (var alt in alternatives)
                {
                    Marks.Add(alt.Vectors.Select(x => x.Mark).Where(x => x.CriterionId == crit.CriterionId).FirstOrDefault());
                }
                var max = Marks.Select(x => x.NumericMark).Max();
                var min = Marks.Select(x => x.NumericMark).Min();
                foreach (var alt in alternatives)
                {
                    var vec = alt.Vectors.Where(x => x.Mark.CriterionId == crit.CriterionId).FirstOrDefault();
                    if (vec.Mark.Criterion.OptimType != Models.Enums.OptimalityType.Minimum)
                    {
                        vec.Mark.StandartizedMark = (double)(vec.Mark.NumericMark - min) / (max - min);
                    }
                    else
                    {
                        vec.Mark.StandartizedMark = (double)(max - vec.Mark.NumericMark) / (max - min);
                    }
                }
            }
            return alternatives;
        }

        private Alternative MaximinimumConvolution(List<Alternative> input)
        {
            var Mins = new List<double>();
            foreach (var el in input)
            {
                Mins.Add(el.Vectors.Select(x => x.Mark).Select(x => x.StandartizedMark).Min());
            }
            var max = Mins.Max();
            return input.Where(x => x.Vectors.Select(y => y.Mark).Select(y => y.StandartizedMark).Contains(max)).FirstOrDefault();
        }
    }
}