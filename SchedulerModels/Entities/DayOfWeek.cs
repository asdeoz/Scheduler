using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerModels.Entities
{
    [Table("DaysOfWeek")]
    public class DayOfWeek
    {
        public int DayOfWeekId { get; set; }
        [Required(ErrorMessage="The day of the week needs a name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        public int NumberOfDay { get; set; }

        public virtual List<Block> Blocks { get; set; }
    }
}
