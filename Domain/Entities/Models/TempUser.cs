using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class TempUser
    {
        [Key]

        public int TempUserId { get; set; }

        [Required]
        public bool IsTempoary { get; set; }
    }
}
