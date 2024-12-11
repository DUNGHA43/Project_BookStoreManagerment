using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public interface IBookReceiptRepository : IRepository<BookReceipt>
    {
        Task<IEnumerable<BookReceipt>> SearchBookReceiptsByIdAsync(string id);
    }
}
