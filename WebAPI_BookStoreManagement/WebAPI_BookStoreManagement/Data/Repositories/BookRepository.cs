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

        public async Task<IEnumerable<Book>> SearchBookAsync(string namebook, string cate, string pub, string author)
        {
            var rs = from books in _context.books
                     join categories in _context.categories on books.idcate equals categories.id
                     join authors in _context.authors on books.idau equals authors.id
                     join publisher in _context.publishers on books.idpub equals publisher.id
                     where books.namebook.Contains(namebook)
                     && categories.namecategory.Contains(cate)
                     && publisher.namepublisher.Contains(pub)
                     && authors.fullname.Contains(author)
                     select books;

            return await rs.ToListAsync();
        }

        public async Task<IEnumerable<Book>> SearchBooksByNameAsync(string namebook)
        {
            return await _dbSet.Where(b => b.namebook.Contains(namebook)).ToListAsync();
        }

        public async Task<IEnumerable<Book>> SearchBooksByPublisherAsync(int? idpub, string namebook)
        {
            return await _dbSet.Where(b => b.idpub == idpub && b.namebook.Contains(namebook)).ToListAsync();
        }
    }
}
