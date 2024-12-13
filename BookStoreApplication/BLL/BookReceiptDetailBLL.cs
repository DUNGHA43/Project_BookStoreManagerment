using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
using Newtonsoft.Json;
using System.Net.Http;

namespace BLL
{
    public class BookReceiptDetailBLL
    {
        private readonly BookReceiptDetailDAL _bookReceiptDetail;

        public BookReceiptDetailBLL()
        {
            _bookReceiptDetail = new BookReceiptDetailDAL();
        }

        public async Task<IEnumerable<BookReceiptDetailDTO>> GetAllBRAsync(string idreceipt)
        {
            return await _bookReceiptDetail.GetAllBRAsync(idreceipt);
        }
        public async Task<bool> AddBookInDetailAsync(BookReceiptDetailDTO detail)
        {
            return await _bookReceiptDetail.AddBookInDetailAsync(detail);
        }

        public async Task<bool> DeleteBookInDetailAsync(string idreceipt, string idbook)
        {
            return await _bookReceiptDetail.DeleteBookInDetailAsync(idreceipt, idbook);
        }
    }
}
