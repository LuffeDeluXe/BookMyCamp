using Application.RepositoryInterfaces;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public InvoiceRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<int> CreateInvoiceAsync(Invoice invoice)
        {
            int result;

            await _dbContext.AddAsync(invoice);

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<Invoice?> GetInvoiceByIdAsync(int id)
        {
            return await _dbContext.Invoices.FindAsync(id);
        }

        public async Task<int> UpdateInvoiceAsync(Invoice invoice)
        {
            int result;

            _dbContext.Update(invoice);

            return result = await _dbContext.SaveChangesAsync();
        }

        public async Task<int> DeleteInvoiceAsync(Invoice invoice)
        {
            int result;

            _dbContext.Invoices.Remove(invoice);

            return result = await _dbContext.SaveChangesAsync();
        }
    }
}
