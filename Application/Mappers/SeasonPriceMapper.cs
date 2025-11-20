using Application.DTOs;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class SeasonPriceMapper
    {
        public static SeasonPrice ToEntity(this CreateUpdateSeasonPriceDTO dto)
            => new SeasonPrice { Price = dto.Price, SeasonEnd = dto.SeasonEnd, SeasonName = dto.SeasonName, SeasonStart = dto.SeasonStart };

        public static SeasonPrice ToEntity(this CreateUpdateSeasonPriceDTO dto, SeasonPrice existing)
        {
            existing.SeasonStart = dto.SeasonStart;
            existing.SeasonEnd = dto.SeasonEnd;
            existing.SeasonName = dto.SeasonName;
            existing.Price = dto.Price;

            return existing;
        }

        public static SeasonPriceDTO ToDto (this SeasonPrice entity)
            => new SeasonPriceDTO { Price = entity.Price, SeasonEnd = entity.SeasonEnd, SeasonPriceId = entity.SeasonPriceId, SeasonStart = entity.SeasonStart };
    }
}
