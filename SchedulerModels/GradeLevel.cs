using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerModels
{
    public class GradeLevel
    {
        public int GradeLevelId { get; set; }
        public string Name { get; set; }
        public virtual List<Block> Blocks { get; set; }
    }
}
