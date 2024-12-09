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
    }
}
