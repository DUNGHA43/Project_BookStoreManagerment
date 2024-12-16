using DAL;
using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

        public async Task<IEnumerable<AuthorDTO>> SearchAuthorByName(string name)
        {
            return await _author.SearchAuthorByName(name);
        }

        public async Task<bool> AddAuthorAsync(AuthorDTO author)
        {
            return await _author.AddAsync(author);
        }

        public async Task<bool> UpdateAuthorAsync(AuthorDTO author)
        {
            return await _author.UpdateAsync(author);
        }

        public async Task<bool> DeleteAuthorAsync(int? id)
        {
            return await _author.DeleteAsync(id);
        }
    }
}
