using System.ComponentModel.DataAnnotations;

namespace OMGT_Lab1.Models
{
    public class Result
    {
        [Key]
        public int ResultId { get; set; }
        public int Range { get; set; }
        public int AlternativeWeight { get; set; }
        
        public int AlternativeId { get; set; }
        public Alternative Alternative { get; set; }

        public int LPRId { get; set; }
        public LPR LPR { get; set; }
    }
}
