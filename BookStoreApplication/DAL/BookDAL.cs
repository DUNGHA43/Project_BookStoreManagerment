using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookDAL
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7273/api/Book";

        public BookDAL()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<BookDTO>> GetAllBookAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(_apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var books = JsonConvert.DeserializeObject<List<BookDTO>>(responsebody);
                    return books;
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception(errorResponse);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<BookDTO>> GetALlBookByPubAsync(int idpub)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/booksbypub/{idpub}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var books = JsonConvert.DeserializeObject<List<BookDTO>>(responsebody);
                    return books;
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception(errorResponse);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<BookDTO>> SearchBookByPubAsync(int idpub, string? namebook)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/searchbooksbypub/{idpub}, {namebook}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var books = JsonConvert.DeserializeObject<List<BookDTO>>(responsebody);
                    return books;
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception(errorResponse);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<IEnumerable<BookDTO>> SearchBookByNameAsync(string? namebook)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/searchbyname/{namebook}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var books = JsonConvert.DeserializeObject<List<BookDTO>>(responsebody);
                    return books;
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception(errorResponse);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
