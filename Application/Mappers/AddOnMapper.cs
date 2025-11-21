using Application.DTOs;
using AutoMapper;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.Configuration;

namespace Application.Mappers
{
    public static class AddOnMapper
    {
        public static AddOn ToEntity(this CreateAddOnDTO dto)
            => new AddOn { Product = dto.Product, Price = dto.Price };

        public static AddOn ToEntity(this UpdateAddOnDTO dto, AddOn existing)
        {
            existing.Product = dto.Product;
            existing.Price = dto.Price;
            return existing;
        }

        public static AddOnListDTO ToListDto(this AddOn entity)
            => new AddOnListDTO { AddOnId = entity.AddOnId, Product = entity.Product, Price = entity.Price };

        public static AddOnDetailsDTO ToDetailsDto(this AddOn entity)
            => new AddOnDetailsDTO { AddOnId = entity.AddOnId, Product = entity.Product, Price = entity.Price };
    }
}
