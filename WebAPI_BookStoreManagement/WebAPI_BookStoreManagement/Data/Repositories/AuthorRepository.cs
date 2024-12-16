using Microsoft.EntityFrameworkCore;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public class AuthorRepository : Repository<Author>, IAuthorRepository
    {
        private readonly DBBookStoreContext _context;

        public AuthorRepository(DBBookStoreContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Author>> SearchAuthorByName(string name)
        {
            return await _dbSet.Where(au => au.fullname.Contains(name)).ToListAsync();
        }
    }
}
