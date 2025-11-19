using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateInvoiceDTO
    {
        public int BookingId { get; set; }
    }

    public class InvoiceListDTO
    {
        public int InvoiceId { get; set; }

        public int BookingId { get; set; }

        public DateOnly OrderDate { get; set; }

    }


}

