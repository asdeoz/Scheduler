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
    }
}
