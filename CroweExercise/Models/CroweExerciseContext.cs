using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace CroweExercise.Models
{
    public class CroweExerciseContext : DbContext
    {
        public CroweExerciseContext(DbContextOptions<CroweExerciseContext> options)
            : base(options)
        {
        }

        public DbSet<CroweItem> CroweItems { get; set; }
    }
}