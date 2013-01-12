using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerModels
{
    public class AssignmentGrade
    {
        public int AssignmentGradeId { get; set; }
        public decimal Grade { get; set; }

        public virtual Student Student { get; set; }
        public virtual Assignment Assignment { get; set; }
        public virtual Block Block { get; set; }
        public virtual Teacher GradingTeacher { get; set; }
    }
}
