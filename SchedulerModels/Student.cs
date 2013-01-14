using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerModels
{
    public class Student : Person
    {
        [Display(Name="Mother's Name")]
        public string MotherName { get; set; }
        [Display(Name="Father's Name")]
        public string FatherName { get; set; }

        public virtual List<Block> Blocks { get; set; }
        public virtual List<Lesson> Lessons { get; set; }
    }
}
