using Microsoft.EntityFrameworkCore;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public class BookReceiptRepository : Repository<BookReceipt>, IBookReceiptRepository
    {
        private DBBookStoreContext _context;

        public BookReceiptRepository(DBBookStoreContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<BookReceipt>> SearchBookReceiptsByIdAsync(string id)
        {
            return await _dbSet.Where(br => br.id.Contains(id)).ToListAsync();
        }
    }
}
