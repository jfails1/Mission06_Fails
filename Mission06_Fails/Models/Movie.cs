using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mission06_Fails.Models
{
    public class Movie
    {
        [Key]
        [Required]
        public int MovieId { get; set; }

        [ForeignKey("CategoryId")]
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Sorry, you must enter a Title")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Sorry, you must enter the Year")]
        [Range(1888, int.MaxValue, ErrorMessage = "The year must be greater than or equal to 1888")]
        public int Year { get; set; }
        public string? Director { get; set; }
        public string? Rating { get; set; }

        [Required]
        public bool Edited { get; set; }
        public string? LentTo { get; set; } // Not required

        [Required]
        public bool CopiedToPlex { get; set; }
        public string? Notes { get; set; } // Not required
    }
}
