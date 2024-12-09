using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Services
{
    public interface IBookReceiptDetailServices
    {
        Task<IEnumerable<BookReceiptDetail>> GetAllBookReceiptDetailAsync(string idbookreceipt);
        Task AddBookReceiptDetailAsync(BookReceiptDetail bookreceiptdetail);
        Task DeleteBookReceiptDetailAsync(string idreceipt, string idbook);
        Task<float?> CalculateTotalAsync(string idbook, int? quanlity);
        Task<BookReceiptDetail> GetBookReceiptDetailByIdAsync(string idbookreceipt, string idbook);
    }
}
