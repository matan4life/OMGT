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
    public class VoteController : Controller
    {
        private DataContext db = new DataContext();

        public IActionResult Landing()
        {
            return View();
        }

        public IActionResult Index()
        {
            var result = db.Alternatives
                .Include(x => x.Vectors)
                .ThenInclude(x => x.Mark)
                .ThenInclude(x => x.Criterion)
                .Include(x => x.Results)
                .ThenInclude(x => x.LPR);
            ViewBag.Criteria = db.Criteria.ToList();
            return View(result);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index(int id)
        {
            var values = new Dictionary<Alternative, int>();
            var result = db.Alternatives
                .Include(x => x.Vectors)
                .ThenInclude(x => x.Mark)
                .ThenInclude(x => x.Criterion)
                .Include(x => x.Results)
                .ThenInclude(x => x.LPR);
            var lpr = db.LPR.Where(x => x.LPRName == User.Identity.Name).FirstOrDefault();
            if (lpr.Results is null)
            {
                lpr.Results = new List<Result>();
            }
            db.Results.RemoveRange(db.Results.Where(x => x.LPRId == lpr.LPRId));
            db.SaveChanges();
            foreach (var a in result)
            {
                string value = Request.Form.FirstOrDefault(x => x.Key == a.AlternativeName).Value[0];
                values.Add(a, int.Parse(value));
            }
            ViewBag.Criteria = db.Criteria.ToList();
            foreach (var el in values)
            {
                lpr.Results.Add(new Result()
                {
                    LPRId = lpr.LPRId,
                    AlternativeId = el.Key.AlternativeId,
                    Range = el.Value
                });
            }
            db.SaveChanges();
            return Redirect("/Vote/Result");
        }

        public IActionResult Result()
        {
            var dict = new Dictionary<List<LPR>, List<Result>>();
            var lprs = db.LPR.Include(x => x.Results).ThenInclude(x => x.Alternative).ToList();
            foreach (var l in lprs)
            {
                foreach (var r in dict.Values)
                {
                    if (AreListsEqual(l.Results, r))
                    {
                        dict.Where(x => AreListsEqual(x.Value, r)).FirstOrDefault().Key.Add(l);
                        break;
                    }
                }
                if (!dict.Keys.ToList().SelectMany(x => x).Contains(l))
                {
                    dict.Add(new List<LPR>() { l }, l.Results.OrderBy(x=>x.Range).ToList());
                }
            }
            var topdict = new Dictionary<Alternative, int>();
            foreach (var pair in dict)
            {
                if (!topdict.Keys.Contains(pair.Value[0].Alternative))
                {
                    topdict.Add(pair.Value[0].Alternative, pair.Key.Count);
                }
                else
                {
                    topdict[pair.Value[0].Alternative] += pair.Key.Count;
                }
            }
            ViewBag.Dict = dict;
            ViewBag.Alt = db.Alternatives.ToList();
            ViewBag.Tops = topdict.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            foreach (var pair in topdict)
            {
                if (pair.Value > topdict.Values.Sum() / 2)
                {
                    ViewBag.Top = pair.Key;
                    return View();
                }
            }
            var tmp = topdict.OrderByDescending(x => x.Value).Take(2).ToDictionary(x => x.Key, x => x.Value);
            var dict2 = new Dictionary<Alternative, int>();
            foreach (var el in topdict.OrderByDescending(x=>x.Value).Take(2).ToDictionary(x=>x.Key, x => x.Value))
            {
                dict2.Add(el.Key, 0);
            }
            foreach (var el in dict)
            {
                if (el.Value.IndexOf(el.Value.Find(x=>x.AlternativeId==tmp.Keys.First().AlternativeId))<
                    el.Value.IndexOf(el.Value.Find(x => x.AlternativeId == tmp.Keys.Last().AlternativeId))){
                    dict2[tmp.Keys.First()] += el.Key.Count;
                }
                else
                {
                    dict2[tmp.Keys.Last()] += el.Key.Count;
                }
            }
            ViewBag.Dict2 = dict2;
            return View(db.LPR.Include(x => x.Results).ThenInclude(x => x.Alternative));
        }

        private static bool AreListsEqual(List<Result> a, List<Result> b)
        {
            a = a.OrderBy(x => x.Range).ToList();
            b = b.OrderBy(x => x.Range).ToList();
            if (a.Count != b.Count) return false;
            for (int i = 0; i < a.Count; i++)
            {
                if (a[i].AlternativeId != b[i].AlternativeId) return false;
            }
            return true;
        }

        private static List<int> IsGreaterThanOther(Dictionary<List<LPR>, List<Result>> dict, Result r1, Result r2)
        {
            var result = new List<int>() { 0, 0 };
            foreach (var pair in dict)
            {
                if (pair.Value.IndexOf(r1) > pair.Value.IndexOf(r2))
                {
                    result[0] += pair.Key.Count;
                }
                else result[1] += pair.Key.Count;
            }
            return result;
        }
    }
}