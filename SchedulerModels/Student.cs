using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerModels
{
    public class Student : Person
    {
        public string MotherName { get; set; }
        public string FatherName { get; set; }

        public virtual List<Block> Blocks { get; set; }
        public virtual List<Lesson> Lessons { get; set; }
    }
}
