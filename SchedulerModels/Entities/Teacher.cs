using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerModels.Entities
{
    [Table("Teachers")]
    public class Teacher : Person
    {
        public string Education { get; set; }

        public virtual List<Block> Blocks { get; set; }
        public virtual List<Lesson> LessonsGiven { get; set; }
    }
}
