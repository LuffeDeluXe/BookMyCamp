using Application.Exceptions;
using Application.Messages;
using Application.RepositoryInterfaces;
using Application.ServiceInterfaces;
using Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly IInvoiceRepository _invoiceRepository;

        public InvoiceService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public async Task<string> CreateInvoiceAsync(Invoice invoice)
        {
            int result;

            string message;
            result = await _invoiceRepository.CreateInvoiceAsync(invoice);

            if (result == 0)
            {
                throw new CreateEntityException<Invoice>();
            }

            return SuccessMessage.Created<Invoice>();
        }

        public async Task<Invoice?> GetInvoiceByIdAsync(int id)
        {
            return await _invoiceRepository.GetInvoiceByIdAsync(id);
        }

        public async Task<string> UpdateInvoiceAsync(Invoice existingInvoice, Invoice updatedInvoice)
        {
            int result;

            string message;
            result = await _invoiceRepository.UpdateInvoiceAsync(existingInvoice);

            if (result == 0)
            {
                throw new UpdateEntityException<Invoice>(); 
            }

            return SuccessMessage.Updated<Invoice>();
        }

        public async Task<string> DeleteInvoiceAsync(Invoice invoice)
        {
            int result;

            string message;
            result = await _invoiceRepository.DeleteInvoiceAsync(invoice);

            if (result == 0)
            {
                throw new DeleteEntityException<Invoice>(); 
            }

            return SuccessMessage.Deleted<Invoice>();
        }

    }
}
