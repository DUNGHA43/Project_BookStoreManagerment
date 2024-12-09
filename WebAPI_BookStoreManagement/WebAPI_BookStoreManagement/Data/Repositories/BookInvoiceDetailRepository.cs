using Microsoft.EntityFrameworkCore;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public class BookInvoiceDetailRepository : Repository<BookInvoiceDetail>, IBookInvoiceDetailRepository
    {
        private readonly DBBookStoreContext _context;

        public BookInvoiceDetailRepository(DBBookStoreContext context) : base(context)
        {
            _context = context;
        }

        async Task IBookInvoiceDetailRepository.DeleteBookAsync(object idbookinvoice, object idbook)
        {
            var entity = await _dbSet.FindAsync(idbookinvoice, idbook);
            if (entity != null)
                _dbSet.Remove(entity);
        }

        async Task<IEnumerable<BookInvoiceDetail>> IBookInvoiceDetailRepository.GetAllBookInvoiceDetailsByIdAsync(string idbookinvoice)
        {
            return await _dbSet.Where(bid => bid.idinvoice == idbookinvoice).ToListAsync();
        }

        async Task<BookInvoiceDetail> IBookInvoiceDetailRepository.GetBookInvoiceByIdsAsync(object idbookinvoice, object idbook)
        {
            return await _dbSet.FindAsync(idbookinvoice, idbook);
        }

        async Task<float> IBookInvoiceDetailRepository.GetRetailPriceBookAsync(string idbook)
        {
            var book = await _context.Set<Book>().FindAsync(idbook);
            if (book != null)
                return book.retailprice ?? 0;

            throw new Exception("Book not found!");
        }
    }
}
