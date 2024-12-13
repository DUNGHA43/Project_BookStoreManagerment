using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BookReceiptBLL
    {
        private readonly BookReceiptDAL _bookrecipt;
        public BookReceiptBLL() { 
            _bookrecipt = new BookReceiptDAL();
        }

        public async Task<IEnumerable<BookReceiptDTO>> GetAllBookReciptsAsync()
        {
            return await _bookrecipt.GetAllAsync();
        }

        public async Task<IEnumerable<BookReceiptDTO>> SearchBookReceiptAsync(string id)
        {
            return await _bookrecipt.GetByIdAsync(id);
        }

        public async Task<decimal> GetTotalReceiptAsync(string id)
        {
            return await _bookrecipt.GetTotalReceiptAsync(id);
        }

        public async Task<bool> AddBookReceiptAsync(BookReceiptDTO bookReceiptDTO)
        {
            return await _bookrecipt.AddAsync(bookReceiptDTO);
        }

        public async Task<bool> UpdateBookReceiptAsync(BookReceiptDTO bookReceiptDTO)
        {
            return await _bookrecipt.UpdateAsync(bookReceiptDTO);
        }

        public async Task<bool> DeleteBookReceiptAsync(string id)
        {
            return await _bookrecipt.DeleteAsync(id);
        }
    }
}
