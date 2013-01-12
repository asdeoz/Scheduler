using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerModels
{
    [Table("DaysOfWeek")]
    public class DayOfWeek
    {
        public int DayOfWeekId { get; set; }
        public string Name { get; set; }
        public int NumberOfDay { get; set; }

        public virtual List<Block> Blocks { get; set; }
    }
}
