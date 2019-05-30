using OMGT_Lab1.Models.Enums;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OMGT_Lab1.Models
{
    public class Criterion
    {
        public int CriterionId { get; set; }
        [Display(Name = "Criteria name")]
        public string Name { get; set; }
        public int Range { get; set; }
        public int Weight { get; set; }
        [Display(Name = "Criteria type")]
        public CriteriaType Type { get; set; }
        [Display(Name = "Optimaly")]
        public OptimalityType OptimType { get; set; }
        [Display(Name = "Unit")]
        public Units Unit { get; set; }
        [Display(Name = "Scale type")]
        public ScaleTypes ScaleType { get; set; }

        public List<Mark> Marks { get; set; }
    }
}
