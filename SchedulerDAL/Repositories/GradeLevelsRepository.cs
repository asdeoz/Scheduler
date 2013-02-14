using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchedulerModels.Entities;

namespace SchedulerDAL.Repositories
{
    public class GradeLevelsRepository
    {
        SchedulerContext context;

        public GradeLevelsRepository()
        {
            context = new SchedulerContext();
        }

        /// <summary>
        /// Constructor with a context as a parameter
        /// </summary>
        /// <param name="_context">Shared context between repositories</param>
        public GradeLevelsRepository(SchedulerContext _context)
        {
            context = _context;
        }

        public IQueryable<GradeLevel> GradeLevels
        {
            get
            {
                return context.GradeLevels;
            }
        }

        public GradeLevel GetGradeLevel(int id)
        {
            var gradeLevel = context.GradeLevels.Where(gl => gl.GradeLevelId == id).FirstOrDefault();

            return gradeLevel;
        }

        public void SaveGradeLevel(GradeLevel gradeLevel)
        {
            if (gradeLevel.GradeLevelId == 0)
            {
                context.GradeLevels.Add(gradeLevel);
            }

            context.SaveChanges();
        }

        public void DeleteGradeLevel(int id)
        {
            var gradeLevel = GetGradeLevel(id);

            context.GradeLevels.Remove(gradeLevel);

            context.SaveChanges();
        }
    }
}
