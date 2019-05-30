using System.Collections.Generic;

namespace OMGT_Lab1.Models
{
    public class Mark
    {
        public int MarkId { get; set; }
        public string Name { get; set; }
        public string Range { get; set; }
        public int NumericMark { get; set; }
        public double StandartizedMark { get; set; }

        public int CriterionId { get; set; }
        public Criterion Criterion { get; set; }

        public List<Vector> Vectors { get; set; }
    }
}
