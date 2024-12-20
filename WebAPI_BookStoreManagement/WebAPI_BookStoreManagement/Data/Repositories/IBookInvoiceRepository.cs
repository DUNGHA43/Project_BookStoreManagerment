using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public interface IBookInvoiceRepository : IRepository<BookInvoice>
    {
        Task<IEnumerable<BookInvoice>> SearchBookInvoiceById(string id);
        Task<decimal?> CalculateInvoiceTotalAsync(string id);
        Task<IEnumerable<dynamic>> GetStatisticalInvoiceByYearAsync(int year);
        Task<IEnumerable<dynamic>> GetStatisticalInvoiceByQuaterAsync(int quater, int year);
        Task<IEnumerable<dynamic>> GetStatisticalInvoiceByMonthAsync(int month, int year);
        Task<IEnumerable<dynamic>> GetStatisticalRevenueByYearAsync(int year);
        Task<IEnumerable<dynamic>> GetStatisticalRevenueByQuaterAsync(int quater, int year);
        Task<IEnumerable<dynamic>> GetStatisticalRevenueByMonthAsync(int month, int year);
    }
}
