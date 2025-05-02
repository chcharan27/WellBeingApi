using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WellBeing.Services.MentelHealthApi.Models;

    public class MentelHealthApiContext : DbContext
    {
        public MentelHealthApiContext (DbContextOptions<MentelHealthApiContext> options)
            : base(options)
        {
        }

        public DbSet<MoodTracker> MoodTrackers { get; set; } = default!;

public DbSet<WellBeing.Services.MentelHealthApi.Models.Doctor> Doctor { get; set; } = default!;
    }
