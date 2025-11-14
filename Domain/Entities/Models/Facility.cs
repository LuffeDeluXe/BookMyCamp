using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Facility
    {
        [Key]
        public int FacilityId { get; set; }

        [Required]

        public string Accomedations { get; set; }
        [Required]

        public string Category { get; set; }
    }
}
