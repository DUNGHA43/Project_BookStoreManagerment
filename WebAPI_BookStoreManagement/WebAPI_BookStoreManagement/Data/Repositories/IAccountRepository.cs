using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.DTO;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public interface IAccountRepository : IRepository<Account>
    {
        Task<Account> LoginApp(object username, object password);
    }
}
