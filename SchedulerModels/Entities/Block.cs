﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerModels.Entities
{
    public class Block
    {
        public int BlockId { get; set; }
        [Required(ErrorMessage = "The block needs a name to identify it")]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(250)]
        public string Description { get; set; }
        [Display(Name = "Is it active?")]
        public bool IsActive { get; set; }
        [Display(Name = "Start date")]
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [Display(Name = "End date")]
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        public int? GradeLevelId { get; set; }
        public int? TeacherId { get; set; }

        [ForeignKey("GradeLevelId")]
        public virtual GradeLevel Grade { get; set; }
        public virtual List<Student> Students { get; set; }
        public virtual List<BlockDay> ScheduledDays { get; set; }
        [ForeignKey("TeacherId")]
        public virtual Teacher Teacher { get; set; }

        //public virtual List<DayOfWeek> ScheduledDays { get; set; }

        public void AddBlockDay(BlockDay day)
        {
            var existDay = ScheduledDays.Where(d => d.Day == day.Day).FirstOrDefault();

            if (existDay != null)
            {
                existDay.StartTime = day.StartTime;
                existDay.EndTime = day.EndTime;
            }
            else
            {
                ScheduledDays.Add(day);
            }
        }
    }
}
