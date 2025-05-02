using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WellBeing.Services.MentelHealthApi.Models
{
    public class MoodTrackerDto
    {
        
        [Required]
        [Column("EntryDate")]
        public DateOnly DateTimeOfEntry { get; set; }

        [Required]
        public string UserId { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; }

        [Range(0, 100)]
        public int Score { get; set; }

        [MaxLength(50)]
        public string? CurrentMood { get; set; }

    }
}
