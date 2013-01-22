using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using SchedulerModels.Entities;

namespace SchedulerDAL
{
    public class SchedulerDbInitializer : DropCreateDatabaseIfModelChanges<SchedulerContext>
    {
        protected override void Seed(SchedulerContext context)
        {
            base.Seed(context);
        }
    }
}
