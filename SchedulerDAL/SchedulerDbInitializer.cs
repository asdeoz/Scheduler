using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SchedulerModels.Entities;

namespace SchedulerDAL
{
    public class SchedulerDbInitializer : DropCreateDatabaseIfModelChanges<SchedulerContext>
    //public class SchedulerDbInitializer : DropCreateDatabaseAlways<SchedulerContext>
    {
        protected override void Seed(SchedulerContext context)
        {
            //Teachers//////////////////////////////////////////////////////////////////////////////////////////////////////
            var teachers = new List<Teacher>
            {
                new Teacher{Name="Peter", Surname1="Barrett", Surname2="", Education="Education Degree", Phone="641874951", IdNumber="57498535R", Email="p.barrett@emac.com"},
                new Teacher{Name="Esther", Surname1="Gonzalez", Surname2="Perez", Education="Magisterio", Phone="679844547", IdNumber="15749832L", Email="e.gonzalez@emac.com"},
                new Teacher{Name="Cheryl", Surname1="Farr", Surname2="Cooney", Education="TEFL", Phone="655624512", IdNumber="74568512A", Email="c.farr@emac.com"},
            };

            teachers.ForEach(t => context.Teachers.Add(t));
            context.SaveChanges();

            //Students//////////////////////////////////////////////////////////////////////////////////////////////////////
            var students = new List<Student>
            {
                new Student{Name="John", Surname1="Fringe", Surname2="", MotherName="Paola", FatherName="John", IdNumber="74529758G", Email="John00@mail.com", Phone="937461262"},
                new Student{Name="Julia", Surname1="Lawn", Surname2="Rogers", MotherName="Geraldine", FatherName="Joel", IdNumber="73985638F", Email="Julia99@mail.com", Phone="638274590"},
                new Student{Name="Seth", Surname1="Garcia", Surname2="Kaett", MotherName="Martha", FatherName="Mike", IdNumber="86531543T", Email="Seth05@mail.com", Phone="934576975"},
            };

            students.ForEach(s => context.Students.Add(s));
            context.SaveChanges();

            //GradeLevels///////////////////////////////////////////////////////////////////////////////////////////////////
            var gradeLevels = new List<GradeLevel>
            {
                new GradeLevel{Name="First grade", Level="Beginners", Ages="6-9"},
                new GradeLevel{Name="Second grade", Level="Intermediate", Ages="10-13"},
                new GradeLevel{Name="Third grade", Level="Upper", Ages="14-17"},
            };

            gradeLevels.ForEach(g => context.GradeLevels.Add(g));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
