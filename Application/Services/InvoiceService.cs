using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.ServiceInterfaces;

namespace Application.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceService _invoiceService;

        public InvoiceService(IInvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }
    }
}
