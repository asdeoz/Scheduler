using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerModels
{
    public class GradeLevel
    {
        public int GradeLevelId { get; set; }
        [Required(ErrorMessage="A grade level needs a name to identify it")]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Ages { get; set; }
        [MaxLength(50)]
        public string Level { get; set; }

        public virtual List<Block> Blocks { get; set; }
        public virtual List<Material> Materials { get; set; }
    }
}
