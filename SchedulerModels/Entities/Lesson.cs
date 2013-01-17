using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerModels.Entities
{
    public class Lesson
    {
        public int LessonId { get; set; }
        [Required(ErrorMessage = "A date is necessary for the lesson")]
        public DateTime Date { get; set; }
        [Display(Name = "Is it a holiday?")]
        public bool IsHoliday { get; set; }

        public virtual List<LessonAttendance> Attendance { get; set; }
        public virtual List<Assignment> AssignmentsGiven { get; set; }
        public virtual List<Assignment> AssignmentsCorrected { get; set; }
        public virtual Teacher Teacher { get; set; }
        [Required(ErrorMessage = "A lesson must be of a block")]
        public virtual Block Block { get; set; }
    }
}
