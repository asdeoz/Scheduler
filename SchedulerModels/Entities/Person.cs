using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SchedulerModels.Entities
{
    [Table("People")]
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        [Required(ErrorMessage="A person needs a name")]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required(ErrorMessage="A person needs at least a surname")]
        [MaxLength(50)]
        [Display(Name="First Surname")]
        public string Surname1 { get; set; }
        [MaxLength(50)]
        [Display(Name="Second Surname")]
        public string Surname2 { get; set; }
        [Required(ErrorMessage="A person needs an Id Number to be identified")]
        [Display(Name="Id Number")]
        public string IdNumber { get; set; }
        [Display(Name="Phone Number")]
        public string Phone { get; set; }
        [Display(Name="E-mail Address")]
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
