using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities.Models
{
    public class SeasonPrice
    {
        public int SeasonPriceId { get; set; }

        public string SeasonName { get; set; }

        public int Price { get; set; }

        public DateOnly SeasonStart { get; set; }

        public DateOnly SeasonEnd { get; set; }
    }
}
