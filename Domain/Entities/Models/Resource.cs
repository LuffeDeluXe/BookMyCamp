using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Resource
    {
        [Key]
        public int ResourceId { get; set; }

        [Required]
        public string ResourceLocation { get; set; }

        [Required]
        public string ResourceType { get; set; }

        [Required]
        public int Size { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public int BasePrice { get; set; }

        [Required]
        [ForeignKey ("SeasonPriceId")]

        public int SeasonPriceID { get; set; }

        public virtual SeasonPrice SeasonPrice { get; set; }
        

        [Required]
        public string Description { get; set; }

    }
}
