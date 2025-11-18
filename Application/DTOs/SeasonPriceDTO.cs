using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class CreateUpdateSeasonPriceDTO
    {

        public string SeasonName { get; set; }

        public int Price { get; set; }

        public DateOnly SeasonStart { get; set; }

        public DateOnly SeasonEnd { get; set; }
    }

    public class SeasonPriceDTO
    {
        public int SeasonPriceId { get; set; }
        public string SeasonName { get; set; }

        public int Price { get; set; }

        public DateOnly SeasonStart { get; set; }

        public DateOnly SeasonEnd { get; set; }
    }
}
