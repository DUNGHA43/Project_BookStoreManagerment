using Microsoft.EntityFrameworkCore;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        private readonly DBBookStoreContext _context;

        public BookRepository(DBBookStoreContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Book>> GetAllBooksByPublisherAsync(int? idpub)
        {
            return await _dbSet.Where(b => b.idpub == idpub).ToListAsync();
        }

        public async Task<IEnumerable<Book>> SearchBooksByPublisherAsync(int? idpub, string namebook)
        {
            return await _dbSet.Where(b => b.idpub == idpub && b.namebook.Contains(namebook)).ToListAsync();
        }
    }
}
