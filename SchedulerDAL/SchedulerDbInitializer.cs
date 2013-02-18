using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SchedulerModels.Entities;

namespace SchedulerDAL
{
    public class SchedulerDbInitializer : DropCreateDatabaseIfModelChanges<SchedulerContext>
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
                new Student{Name="John", Surname1="", Surname2="", MotherName="", FatherName="", IdNumber="", Email="", Phone=""},
                new Student{Name="Julia", Surname1="", Surname2="", MotherName="", FatherName="", IdNumber="", Email="", Phone=""},
                new Student{Name="Seth", Surname1="", Surname2="", MotherName="", FatherName="", IdNumber="", Email="", Phone=""},
            };

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
