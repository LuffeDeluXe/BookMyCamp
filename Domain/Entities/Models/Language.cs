using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Language
    {
        [Key]
        public int LanguageId { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
