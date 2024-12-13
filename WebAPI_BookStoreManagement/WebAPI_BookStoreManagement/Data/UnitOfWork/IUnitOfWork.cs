using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.Repositories;

namespace WebAPI_BookStoreManagement.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository Account { get; }
        IStaffRepository Staff { get; }
        IRepository<Category> Categories { get; }
        IRepository<Publisher> Publisher { get; }
        IRepository<Author> Author { get; }
        IBookRepository Books { get; }
        IBookReceiptRepository BooksReceipt { get; }
        IBookReceiptDetailRepository BookReceiptDetail { get; }
        IBookInvoiceRepository BookInvoice { get; }
        IBookInvoiceDetailRepository BookInvoiceDetail { get; }
        Task SaveChangeAsync();
    }
}
