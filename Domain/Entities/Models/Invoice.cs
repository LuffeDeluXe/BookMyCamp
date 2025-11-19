using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class Invoice
    {
        [Key]
        public int InvoiceId { get; set; }

        [Required]
        public DateOnly OrderDate { get; set; }

        [ForeignKey(nameof(BookingId))]
        public int BookingId { get; set; }

        public virtual Booking Booking { get; set; }


        [Required]
        public int TotalSum { get; set; }
    }
}
