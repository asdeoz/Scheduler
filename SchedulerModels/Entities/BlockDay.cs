using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerModels.Entities
{
    public class BlockDay
    {
        public int BlockDayId { get; set; }
        public int Day { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int? BlockId { get; set; }
        [ForeignKey("BlockId")]
        public virtual Block Block { get; set; }
    }
}
