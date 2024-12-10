using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AccountBLL
    {
        private readonly AccountDAL _accoutnDAL;

        public AccountBLL()
        {
            _accoutnDAL = new AccountDAL();
        }

        public Task<AccountDTO> LoginApp(string username, string password)
        {
            return _accoutnDAL.LoginAsync(username, password);
        }

        public async Task<IEnumerable<AccountDTO>> ShowAllAccounts()
        {
            return await _accoutnDAL.GetAllAccountAsync();
        }

        public async Task<IEnumerable<AccountDTO>> SearchStaffByUsername(string username)
        {
            return await _accoutnDAL.GetByUsername(username);
        }

        public async Task<bool> AddAccountAsync(AccountDTO accountDTO)
        {
            return await _accoutnDAL.AddAsync(accountDTO);
        }

        public async Task<bool> UpdateAccountAsync(AccountDTO accountDTO)
        {
            return await _accoutnDAL.UpdateAsync(accountDTO);
        }

        public async Task<bool> DeleteAccountAsync(string username)
        {
            return await _accoutnDAL.DeleteAsync(username);
        }
    }
}
