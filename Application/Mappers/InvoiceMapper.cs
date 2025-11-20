using Application.DTOs;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class InvoiceMapper
    {
        public static Invoice ToEntity(this InvoiceListDTO dto)
            => new Invoice { BookingId = dto.BookingId };

        public static InvoiceListDTO ToListDTO(this Invoice entity)
            => new InvoiceListDTO { BookingId = entity.BookingId, OrderDate = entity.OrderDate, InvoiceId = entity.InvoiceId };

        public static InvoiceDetailsDTO ToDetailsDTO(this Invoice entity)
            => new InvoiceDetailsDTO { BookingId = entity.BookingId, InvoiceId = entity.InvoiceId, OrderDate = entity.OrderDate, TotalSum = entity.TotalSum };
    }
}



