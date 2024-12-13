using Microsoft.EntityFrameworkCore;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public class BookInvoiceRepository : Repository<BookInvoice>, IBookInvoiceRepository
    {
        private readonly DBBookStoreContext _context;

        public BookInvoiceRepository(DBBookStoreContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<decimal?> CalculateInvoiceTotalAsync(string id)
        {
            var total = await _context.bookinvoicedetails
                                        .Where(totaldetail => totaldetail.idinvoice == id)
                                        .SumAsync(totaldetail => totaldetail.totalprice);

            return total ?? -1;
        }

        public async Task<IEnumerable<BookInvoice>> SearchBookInvoiceById(string id)
        {
            return await _dbSet.Where(bi => bi.id.Contains(id)).ToListAsync();
        }
    }
}
