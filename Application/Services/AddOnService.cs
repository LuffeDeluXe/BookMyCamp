using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ServiceInterfaces;

namespace Application.Services
{
    public class AddOnService : IAddOnService
    {
        private readonly IAddOnService _addOnService;

        public AddOnService(IAddOnService addOnService)
        {
            _addOnService = addOnService;
        }
    }
}
