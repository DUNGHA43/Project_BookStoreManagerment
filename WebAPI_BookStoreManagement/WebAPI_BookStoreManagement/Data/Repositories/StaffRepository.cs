using Microsoft.EntityFrameworkCore;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public class StaffRepository : Repository<Staff>, IStaffRepository
    {
        private readonly DBBookStoreContext _context;

        public StaffRepository(DBBookStoreContext context) : base(context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Staff>> SearchByNameAsync(string name)
        {
            return await _dbSet.Where(staff => staff.fullname.Contains(name)).ToListAsync();
        }
    }
}
