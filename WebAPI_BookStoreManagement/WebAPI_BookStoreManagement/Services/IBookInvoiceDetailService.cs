using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Services
{
    public interface IBookInvoiceDetailService
    {
        Task<IEnumerable<BookInvoiceDetail>> GetAllBookInvoiceDetailAsync(string idbookinvoice);
        Task AddBookInvoiceDetailAsync(BookInvoiceDetail bookinvoicedetail);
        Task DeleteBookInvoiceDetailAsync(string idinvoice, string idbook);
        Task<float?> CalculateTotalAsync(string idbook, int? quanlity);
        Task<BookInvoiceDetail> GetBookInvoiceDetailByIdAsync(string idbookinvoice, string idbook);
    }
}
