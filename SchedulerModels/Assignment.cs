using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerModels
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public bool IsGraded { get; set; }

        public virtual AssignmentGrade AssignmentGrades { get; set; }
        public virtual Lesson LessonGivenIn { get; set; }
        public virtual Lesson LessonCorrectedIn { get; set; }
    }
}
