using Application.DTOs;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.Mappers;

namespace Application.Mappers
{
    public static class AddOnLineMapper
    {
        public static AddOnLine ToEntity(this CreateAddOnLineDTO dto)
            => new AddOnLine { AddOnId = dto.AddOnId, BookingId = dto.BookingId, Amount = dto.Amount };

        public static AddOnLine ToEntity(this UpdateAddOnLineDTO dto, AddOnLine exisiting)
        {
            exisiting.Amount = dto.Amount;
            return exisiting;
        }

        public static AddOnListLineDTO ToListDTO(this AddOnLine entity)
            => new AddOnListLineDTO { AddOnLineId = entity.AddOnLineId, IndividualPrice = entity.AddOn.Price, AddOnProduct = entity.AddOn.Product, PriceSum = entity.PriceSum };

    }
}




