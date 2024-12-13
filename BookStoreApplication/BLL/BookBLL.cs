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
    public class BookBLL
    {
        private readonly BookDAL _book;

        public BookBLL()
        {
            _book = new BookDAL();
        }

        public async Task<IEnumerable<BookDTO>> GetAllBookAsync()
        {
            return await _book.GetAllBookAsync();
        }

        public async Task<IEnumerable<BookDTO>> GetALlBookByPubAsync(int idpub)
        {
            return await _book.GetALlBookByPubAsync(idpub);
        }
        public async Task<IEnumerable<BookDTO>> SearchBookByPubAsync(int idpub, string namebook)
        {
            return await _book.SearchBookByPubAsync(idpub, namebook);
        }
        public async Task<IEnumerable<BookDTO>> SearchBookByNameAsync(string? namebook)
        {
            return await _book.SearchBookByNameAsync(namebook);
        }
    }
}
