using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerModels
{
    public class Lesson
    {
        public int LessonId { get; set; }
        public DateTime Date { get; set; }
        public bool IsHoliday { get; set; }

        public virtual List<LessonAttendance> Attendance { get; set; }
        public virtual List<Assignment> AssignmentsGiven { get; set; }
        public virtual List<Assignment> AssignmentsCorrected { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
