using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Spot : Resource
    {
        [Key]
        public int SpotId { get; set; }

        [Required]
        public int MaximumLength { get; set; }

        [Required]
        public int MaximumWidth { get; set; }
    }
}
