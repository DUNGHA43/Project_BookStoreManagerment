using Microsoft.EntityFrameworkCore;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public class PublisherRepository : Repository<Publisher>, IPublisherRepository
    {
        private readonly DBBookStoreContext _context;

        public PublisherRepository(DBBookStoreContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Publisher>> SearchPubByName(string name)
        {
            return await _dbSet.Where(p => p.namepublisher.Contains(name)).ToListAsync();
        }
    }
}
