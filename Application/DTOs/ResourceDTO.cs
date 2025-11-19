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
    public class CreateListResourceDTO
    {
        public string ResourceLocation { get; set; }

        public int ResourceType { get; set; }
        public int Size { get; set; }

        public int Capacity { get; set; }

        public string Category { get; set; }

        public int BasePrice  { get; set; }


    }

    public class ResourceListDTO
    {
        public int ResourceId { get; set; }

        public int ResourceType { get; set; }
        public int Size { get; set; }

        public int Capacity { get; set; }

        public string Category { get; set; }

        public int SeasonPriceId { get; set; }

    }

    public class ResourceDetailDTO
    {
        public int ResourceId { get; set; }

        public int ResourceType { get; set; }
        public int Size { get; set; }

        public int Capacity { get; set; }

        public string Category { get; set; }

        public int BasePrice { get; set; }

        public int SeasonPriceId { get; set; }

        public string Description { get; set; }

    }
}

