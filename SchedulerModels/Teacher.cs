using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerModels
{
    public class Teacher : Person
    {
        public virtual List<Block> Blocks { get; set; }
        public virtual List<Lesson> LessonsGiven { get; set; }
    }
}
