using Microsoft.EntityFrameworkCore;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public class BookReceiptDetailRepository : Repository<BookReceiptDetail>, IBookReceiptDetailRepository
    {
        private DBBookStoreContext _context;
        public BookReceiptDetailRepository(DBBookStoreContext context) : base(context)
        {
            _context = context;
        }

        public async Task<float> GetImportPriceBookIdAsync(string idbook)
        {
            var book = await _context.Set<Book>().FindAsync(idbook);
            if(book != null)
            {
                return book.importprice ?? 0;
            }

            throw new Exception("Book not found!");
        }

        public async Task DeleteBookAsync(object idbookreceipts, object idbook)
        {
            var entity = await _dbSet.FindAsync(idbookreceipts, idbook);
            if (entity != null) { 
                _dbSet.Remove(entity);
            }
        }

        public async Task<BookReceiptDetail> GetBookReceiptByIdsAsync(object idbookreceipt, object idbook)
        {
            return await _dbSet.FindAsync(idbookreceipt, idbook);
        }

        public async Task<IEnumerable<BookReceiptDetail>> GetAllBookReceiptDetailsByIdAsync(string idbookreceipt)
        {
            return await _dbSet.Where(brd => brd.idreceipt == idbookreceipt).ToListAsync();
        }
    }
}
