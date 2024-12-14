using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AuthorBLL
    {

        private readonly AuthorDAL _author;
        public AuthorBLL() {
            _author = new AuthorDAL();
        }

        public async Task<IEnumerable<AuthorDTO>> GetAllAuthorAsync()
        {
            return await _author.GetAllAuthorAsync();
        }
    }
}
