using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class EmployeeLanguage
    {
        [Key]
        public int EmployeeLanguageId { get; set; }

        [ForeignKey ("EmployeeId")]
        [Required]

        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        [ForeignKey("LanguageId")]
        [Required]

        public int LanguageId { get; set; }

        public virtual Language Language { get; set; }

    }
}
