using DAL;
using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookInvoiceBLL
    {
        private readonly BookInvoiceDAL _bookinvoice;

        public BookInvoiceBLL()
        {
            _bookinvoice = new BookInvoiceDAL();
        }

        public async Task<IEnumerable<BookInvoiceDTO>> GetAllBookInvoiceAsync()
        {
            return await _bookinvoice.GetAllAsync();
        }

        public async Task<IEnumerable<BookInvoiceDTO>> SearchBookInvoiceByIdAsync(string id)
        {
            return await _bookinvoice.GetByIdAsync(id);
        }

        public async Task<decimal> GetTotalInvoiceAsync(string id)
        {
            return await _bookinvoice.GetTotalInvoiceAsync(id);
        }

        public async Task<bool> AddBookInvoiceAsync(BookInvoiceDTO bookInvoiceDTO)
        {
            return await _bookinvoice.AddAsync(bookInvoiceDTO);
        }

        public async Task<bool> UpdateBookInvoiceAsync(BookInvoiceDTO bookInvoiceDTO)
        {
            return await _bookinvoice.UpdateAsync(bookInvoiceDTO);
        }

        public async Task<bool> DeleteBookInvoiceAsync(string id)
        {
            return await _bookinvoice.DeleteAsync(id);
        }
    }
}
