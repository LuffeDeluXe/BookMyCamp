using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs
{
    public class LanguageDTO
    {
        public string Name { get; set; }
    }

    public class LanguageListDTO
    {
        public int LanguageId { get; set; }

        public string Name { get; set; }
    }
}
