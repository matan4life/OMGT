using System.ComponentModel.DataAnnotations;

namespace OMGT_Lab1.Models
{
    public class Vector
    {
        [Key]
        public int VectorId { get; set; }

        public int MarkId { get; set; }
        public Mark Mark { get; set; }

        public int AlternativeId { get; set; }
        public Alternative Alternative { get; set; }
    }
}
