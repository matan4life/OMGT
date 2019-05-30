using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OMGT_Lab1.Models
{
    public class Alternative
    {
        public int AlternativeId { get; set; }
        [Display(Name = "Alternative")]
        public string AlternativeName { get; set; }

        public List<Vector> Vectors { get; set; }

        public List<Result> Results { get; set; }
    }
}
