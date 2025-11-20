using Application.DTOs;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Mappers
{
    public static class LanguageMapper
    {
        public static Language ToEntity(this LanguageDTO dto)
            => new Language { Name = dto.Name };

        public static Language ToEntity(this LanguageDTO dto, Language existing)
        {
            existing.Name = dto.Name;
            return existing;
        }

        public static LanguageListDTO ToDto (this Language entity)
            => new LanguageListDTO { Name = entity.Name, LanguageId = entity.LanguageId };
    }
}
