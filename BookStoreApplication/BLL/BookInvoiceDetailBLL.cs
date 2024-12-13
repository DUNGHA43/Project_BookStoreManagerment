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
    public class BookInvoiceDetailBLL
    {
        private readonly BookInvoiceDetailDAL _detail;
        public BookInvoiceDetailBLL() { 
            _detail = new BookInvoiceDetailDAL();
        }

        public async Task<IEnumerable<BookInvoiceDetailDTO>> GetAllBIAsync(string idinvoice)
        {
            return await _detail.GetAllBIAsync(idinvoice);
        }

        public async Task<bool> AddBookInDetailAsync(BookInvoiceDetailDTO detail)
        {
            return await _detail.AddBookInDetailAsync(detail);
        }

        public async Task<bool> DeleteBookInDetailAsync(string idinvoice, string idbook)
        {
            return await _detail.DeleteBookInDetailAsync(idinvoice, idbook);
        }
    }
}
