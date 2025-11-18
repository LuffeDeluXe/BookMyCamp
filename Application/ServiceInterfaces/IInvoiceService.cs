using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.ServiceInterfaces
{
    public interface IInvoiceService
    {
        Task<string> CreateInvoiceAsync(Invoice invoice);

        Task<Invoice?> GetInvoiceByIdAsync(int id);

        Task<string> UpdateInvoiceAsync(Invoice existingInvoice, Invoice updatedInvoice);

        Task<string> DeleteInvoiceAsync(Invoice invoice);
    }
}
