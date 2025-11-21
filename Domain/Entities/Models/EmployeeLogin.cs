using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class EmployeeLogin
    {
        [Key]
        public int LoginId { get; set; }

        [Required]
        public string? Email { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }

        [Required]
        public string? HashedPassword { get; set; }

        [Required]
        public string? Role { get; set; }
    }
}