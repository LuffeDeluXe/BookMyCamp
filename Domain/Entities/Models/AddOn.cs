using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class AddOn
    {
        [Key]
        public int AddOnId { get; set; }

        [Required]
        public string Product {  get; set; }

        [Required]
        public int Prize { get; set; }
    }
}
