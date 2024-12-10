using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.UnitOfWork;

namespace WebAPI_BookStoreManagement.Services
{
    public class AccountService : IAccountService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AccountService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAccountAsync(Account account)
        {
            if(await _unitOfWork.Account.GetByIdAsync(account.username) != null)
            {
                throw new Exception("Username already exists!");
            }

            await _unitOfWork.Account.AddAsync(account);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteAccountAsync(string username)
        {
            _unitOfWork.Account.DeleteAsync(username);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<Account> GetAccountByUsernameAsync(string username)
        {
            return await _unitOfWork.Account.GetByIdAsync(username);
        }

        public async Task<IEnumerable<Account>> GetAllAcountAsync()
        {
            return await _unitOfWork.Account.GetAllAsync();
        }

        public async Task<Account> LoginAsync(string username, string password)
        {
            return await _unitOfWork.Account.LoginApp(username, password);
        }

        public async Task<IEnumerable<Account>> SearchByUsername(string username)
        {
            return await _unitOfWork.Account.SearchByUsernameAsync(username);
        }

        public async Task UpdateAccountAsync(Account account)
        {
            _unitOfWork.Account.UpdateAsync(account);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
