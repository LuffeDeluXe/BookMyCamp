using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.RepositoryInterfaces
{
    public interface IInvoiceRepository
    {
        Task<int> CreateInvoiceAsync(Invoice invoice);

        Task<Invoice?> GetInvoiceByIdAsync(int id);

        Task<int> UpdateInvoiceAsync(Invoice invoice);

        Task<int> DeleteInvoiceAsync(Invoice invoice);
    }
}
