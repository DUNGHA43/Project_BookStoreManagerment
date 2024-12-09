using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.Repositories;

namespace WebAPI_BookStoreManagement.Data.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IAccountRepository Account { get; }
        IRepository<Staff> Staff { get; }
        IRepository<Category> Categories { get; }
        IRepository<Publisher> Publisher { get; }
        IRepository<Author> Author { get; }
        IRepository<Book> Books { get; }
        IRepository<BookReceipt> BooksReceipt { get; }
        IBookReceiptDetailRepository BookReceiptDetail { get; }
        IRepository<BookInvoice> BookInvoice { get; }
        IBookInvoiceDetailRepository BookInvoiceDetail { get; }
        Task SaveChangeAsync();
    }
}
