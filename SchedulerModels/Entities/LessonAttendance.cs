﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerModels.Entities
{
    public class LessonAttendance
    {
        public int LessonAttendanceId { get; set; }
        public bool HaveAttended { get; set; }

        public virtual Lesson Lesson { get; set; }
        public virtual Student Student { get; set; }
    }
}
