using Microsoft.EntityFrameworkCore;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;
using WebAPI_BookStoreManagement.DTO;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public class AccountRepository : Repository<Account>, IAccountRepository
    {
        private readonly DBBookStoreContext _context;

        public AccountRepository(DBBookStoreContext context) : base(context)
        {
            _context = context;
        }

        public async Task<Account> LoginApp(object username, object password)
        {
            var login = await _dbSet.FirstOrDefaultAsync(us => us.username == username && us.passw == password);

            if (login == null)
                throw new Exception("Wrong username or password!");

            return login;
        }

        public async Task<IEnumerable<Account>> SearchByUsernameAsync(string username)
        {
            return await _dbSet.Where(account => account.username.Contains(username)).ToListAsync();
        }
    }
}
