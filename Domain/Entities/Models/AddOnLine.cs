using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class AddOnLine
    {
        [Key]
        public int AddOnLineId { get; set; }

        [ForeignKey ("AddOnId")]
        public int AddOnId { get; set; }

        [Required]
        public virtual AddOn AddOn { get; set; }

        [ForeignKey(nameof (BookingId))]
        public int BookingId { get; set; }
        public virtual Booking Booking { get; set; }

        [Required]
        public int Amount { get; set; }

        [Required]
        public int PriceSum { get; set; }

    }
}
