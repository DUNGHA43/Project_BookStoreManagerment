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

        public async Task<decimal?> CalculateReceiptTotalAsync(string id)
        {
            var total = await _context.bookreceiptsdetails
                                      .Where(totaldetail => totaldetail.idreceipt == id)
                                      .SumAsync(totaldetail => totaldetail.totalprice);

            return total ?? -1;
        }

        public async Task<IEnumerable<BookReceipt>> SearchBookReceiptsByIdAsync(string id)
        {
            return await _dbSet.Where(br => br.id.Contains(id)).ToListAsync();
        }
    }
}
