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
        public DateTime LessonDay { get; set; }
        public bool IsHoliday { get; set; }

        public virtual List<LessonAttendance> Attendance { get; set; }
    }
}
