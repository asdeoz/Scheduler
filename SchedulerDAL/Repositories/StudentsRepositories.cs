using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SchedulerModels.Entities;

namespace SchedulerDAL.Repositories
{
    public class StudentsRepositories
    {
        SchedulerContext context;

        public StudentsRepositories()
        {
            context = new SchedulerContext();
        }

        /// <summary>
        /// Constructor with a context as a parameter
        /// </summary>
        /// <param name="_context">Shared context between repositories</param>
        public StudentsRepositories(SchedulerContext _context)
        {
            context = _context;
        }

        public IQueryable<Student> Students
        {
            get
            {
                return context.Students;
            }
        }

        public Student GetStudent(int id)
        {
            var student = context.Students.Where(t => t.PersonId == id).FirstOrDefault();

            return student;
        }

        public void SaveStudent(Student student)
        {
            if (student.PersonId == 0)
            {
                context.Students.Add(student);
            }

            context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var student = GetStudent(id);

            context.Students.Remove(student);

            context.SaveChanges();
        }
    }
}
