using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerModels.Entities
{
    public class Material
    {
        public int MaterialId { get; set; }
        [Required(ErrorMessage="A material needs a name")]
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [MaxLength(200)]
        public string Url { get; set; }

        public virtual List<GradeLevel> Grades { get; set; }
    }
}
