using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public abstract class Resource
    {
        [Required]
        public string Type { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public string Description { get; set; }

    }
}
