using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public interface IBookInvoiceRepository : IRepository<BookInvoice>
    {
        Task<IEnumerable<BookInvoice>> SearchBookInvoiceById(string id);
        Task<decimal?> CalculateInvoiceTotalAsync(string id);
    }
}
