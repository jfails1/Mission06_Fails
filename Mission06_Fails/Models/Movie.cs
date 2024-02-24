using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Fails.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieID { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        [Range(1888, int.MaxValue, ErrorMessage = "The year must be greater than or equal to 1888")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }
        [Required]
        public bool Edited { get; set; } // Not required
        public string? LentTo { get; set; } // Not required
        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; } // Not required
    }
}
