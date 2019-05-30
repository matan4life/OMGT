using System.Collections.Generic;

namespace OMGT_Lab1.Models
{
    public class LPR
    {
        public int LPRId { get; set; }
        public string LPRName { get; set; }
        public int LPRRange { get; set; }

        public List<Result> Results { get; set; }
    }
}
