using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Services
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAllAcountAsync();
        Task<Account> GetAccountByUsernameAsync(string username);
        Task AddAccountAsync(Account account);
        Task UpdateAccountAsync(Account account);
        Task DeleteAccountAsync(string username);
        Task<Account> LoginAsync(string username, string password);
        Task<IEnumerable<Account>> SearchByUsername(string username);
    }
}
