using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Cabin : Resource
    {
        [Key]

        public int CabinId { get; set; }

        [Required]
        public string Rooms {  get; set; }

        [Required]
        public string Accomedations { get; set; }
    }
}
