using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Services
{
    public interface IBookInvoiceService
    {
        Task<IEnumerable<BookInvoice>> GetAllBookInvoiceAsync();
        Task<BookInvoice> GetBookInvoiceById(string id);
        Task AddBookInvoiceAsync(BookInvoice bookinvoice);
        Task UpdateBookInvoiceAsync(BookInvoice bookinvoice);
        Task DeleteBookInvoiceAsync(string id);
        Task<IEnumerable<BookInvoice>> SearchBookInvoiceByIdAsync(string id);
        Task<decimal?> CalculateInvoiceTotalAsync(string id);
    }
}
