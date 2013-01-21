using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using SchedulerModels.Entities;

namespace SchedulerDAL
{
    public class SchedulerContext : DbContext
    {
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<GradeLevel> GradeLevels { get; set; }
        public DbSet<Block> Blocks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Assignment>().HasOptional(a => a.AssignmentGrade).WithRequired(a => a.Assignment);
        }
    }
}
