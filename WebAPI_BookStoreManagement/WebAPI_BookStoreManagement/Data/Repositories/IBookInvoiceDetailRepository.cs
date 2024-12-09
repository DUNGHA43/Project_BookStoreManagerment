using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public interface IBookInvoiceDetailRepository : IRepository<BookInvoiceDetail>
    {
        Task<float> GetRetailPriceBookAsync(string idbook);
        Task DeleteBookAsync(object idbookinvoice, object idbook);
        Task<BookInvoiceDetail> GetBookInvoiceByIdsAsync(object idbookinvoice, object idbook);
        Task<IEnumerable<BookInvoiceDetail>> GetAllBookInvoiceDetailsByIdAsync(string idbookinvoice);
    }
}
