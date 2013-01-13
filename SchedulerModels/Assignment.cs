using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerModels
{
    public class Assignment
    {
        public int AssignmentId { get; set; }
        [Required(ErrorMessage="An assignment needs a name to identify it")]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(300)]
        public string Description { get; set; }
        [MaxLength(200)]
        public string Url { get; set; }
        public bool IsGraded { get; set; }

        public virtual AssignmentGrade AssignmentGrades { get; set; }
        public virtual Lesson LessonGivenIn { get; set; }
        public virtual Lesson LessonCorrectedIn { get; set; }
    }
}
