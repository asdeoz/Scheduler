using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerModels
{
    public class TestGrade
    {
        public int TestGradeId { get; set; }
        public decimal Grade { get; set; }
        public DateTime DateTaken { get; set; }

        public virtual Student Student { get; set; }
        public virtual Test Test { get; set; }
        public virtual Block Block { get; set; }
        public virtual Teacher GradingTeacher { get; set; }
    }
}
