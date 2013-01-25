using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchedulerModels.Entities;

namespace SchedulerDAL.Repositories
{
    public class TeachersRepositories
    {
        SchedulerContext context;

        public TeachersRepositories()
        {
            context = new SchedulerContext();
        }

        /// <summary>
        /// Constructor with a context as a parameter
        /// </summary>
        /// <param name="_context">Shared context between repositories</param>
        public TeachersRepositories(SchedulerContext _context)
        {
            context = _context;
        }

        public IQueryable<Teacher> Teachers
        {
            get
            {
                return context.Teachers;
            }
        }

        public Teacher GetTeacher(int id)
        {
            var teacher = context.Teachers.Where(t => t.PersonId == id).FirstOrDefault();

            return teacher;
        }

        public void SaveTeacher(Teacher teacher)
        {
            if (teacher.PersonId == 0)
            {
                context.Teachers.Add(teacher);
            }

            context.SaveChanges();
        }

        public void DeleteTeacher(int id)
        {
            var teacher = GetTeacher(id);

            context.Teachers.Remove(teacher);

            context.SaveChanges();
        }
    }
}
