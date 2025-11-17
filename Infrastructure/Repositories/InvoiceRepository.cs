using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.RepositoryInterfaces;

namespace Infrastructure.Repositories
{
    public class InvoiceRepository : IInvoiceRepository
    {
        private readonly BookMyCampDbContext _dbContext;

        public InvoiceRepository(BookMyCampDbContext dbContext)
        {
            _dbContext = dbContext;
        }
    }
}
