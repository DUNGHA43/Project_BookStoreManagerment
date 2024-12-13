using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;
using WebAPI_BookStoreManagement.Data.Repositories;

namespace WebAPI_BookStoreManagement.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBBookStoreContext _context;

        public IAccountRepository Account { get; private set; }

        public IStaffRepository Staff { get; private set; }

        public IRepository<Category> Categories { get; private set; }

        public IRepository<Publisher> Publisher { get; private set; }

        public IRepository<Author> Author { get; private set; }

        public IBookRepository Books { get; private set; }

        public IBookReceiptRepository BooksReceipt { get; private set; }

        public IBookReceiptDetailRepository BookReceiptDetail { get; private set; }

        public IBookInvoiceRepository BookInvoice { get; private set; }

        public IBookInvoiceDetailRepository BookInvoiceDetail { get; private set; }

        public UnitOfWork(DBBookStoreContext context)
        {
            _context = context;
            Account = new AccountRepository(_context);
            Staff = new StaffRepository(_context);
            Categories = new Repository<Category>(_context);
            Publisher = new Repository<Publisher>(_context);
            Author = new Repository<Author>(_context);
            Books = new BookRepository(_context);
            BooksReceipt = new BookReceiptRepository(_context);
            BookReceiptDetail = new BookReceiptDetailRepository(_context);
            BookInvoice = new BookInvoiceRepository(_context);
            BookInvoiceDetail = new BookInvoiceDetailRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task SaveChangeAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
