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
        Task<IEnumerable<dynamic>> GetStatisticalInvoiceByYearAsync(int year);
        Task<IEnumerable<dynamic>> GetStatisticalInvoiceByQuaterAsync(int quater, int year);
        Task<IEnumerable<dynamic>> GetStatisticalInvoiceByMonthAsync(int month, int year);
    }
}
