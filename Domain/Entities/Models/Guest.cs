using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public abstract class Guest
    {
        [Key]
        public int GuestId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public int PhoneNumber { get; set; }

        public string LandCode { get; set; }

        [ForeignKey ("LanguageId")]
        [Required]
        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }
    }
}
