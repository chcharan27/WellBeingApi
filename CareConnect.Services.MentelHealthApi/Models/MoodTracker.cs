﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CareConnect.Services.MentelHealthApi.Models
{
    public class MoodTracker
    {


        [Key]
        public int EntryId { get; set; }


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

        public int? DoctorID { get; set; }
    }
}
