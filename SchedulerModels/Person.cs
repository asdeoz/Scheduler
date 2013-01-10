using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerModels
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string Surname1 { get; set; }
        public string Surname2 { get; set; }
        public string IdNumber { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string Fullname
        {
            get
            {
                return (Name + " " + Surname1 + " " + Surname2).Trim();
            }
        }
    }
}
