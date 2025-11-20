using Application.DTOs;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class ResourceMapper
    {
        public static Resource ToEntity (this CreateResourceDTO dto)
            => new Resource { ResourceLocation = dto.ResourceLocation, ResourceType = dto.ResourceType, Size = dto.Size, Capacity = dto.Capacity, Category = dto.Category, BasePrice = dto.BasePrice };

        public static Resource ToEntity(this UpdateResourceDTO dto, Resource existing)
        {
            existing.ResourceType = dto.ResourceType;
            existing.Size = dto.Size;
            existing.Capacity = dto.Capacity;
            existing.Category = dto.Category;
            existing.BasePrice = dto.BasePrice;

            return existing;
        }

        public static ResourceListDTO ToDto(this Resource entity)
            => new ResourceListDTO { ResourceId = entity.ResourceId, ResourceType = entity.ResourceType, Size = entity.Size, Capacity = entity.Capacity, Category = entity.Category, SeasonPriceId = entity.SeasonPriceID };

        public static ResourceDetailDTO TodDetailDto (this Resource entity)
            => new ResourceDetailDTO { ResourceId = entity.ResourceId, ResourceType = entity.ResourceType, Size = entity.Size, Capacity = entity.Capacity, Category = entity.Category, SeasonPriceId = entity.SeasonPriceID, BasePrice = entity.BasePrice, Description = entity.Description };
    }
}
