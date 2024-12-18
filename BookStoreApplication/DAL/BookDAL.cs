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

        public async Task<int> GetQuanlityBookAsync(string? id)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/quanlity/{id}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    return Convert.ToInt32(responsebody);
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

        public async Task<IEnumerable<BookDTO>> SearchBooksAsync(string? namebook, string? cate, string? pub, string author)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{namebook},{cate},{pub},{author}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if(response.IsSuccessStatusCode)
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

        public async Task<bool> AddAsync(BookDTO bookDTO)
        {
            try
            {
                var newbook = new BookDTO()
                {
                    id = bookDTO.id,
                    namebook = bookDTO.namebook,
                    quanlitystock = bookDTO.quanlitystock,
                    importprice = bookDTO.importprice,
                    retailprice = bookDTO.retailprice,
                    idcate = bookDTO.idcate,
                    idau = bookDTO.idau,
                    idpub = bookDTO.idpub
                };

                var content = new StringContent(JsonConvert.SerializeObject(newbook), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(_apiUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<bool> UpdateAsync(BookDTO bookDTO)
        {
            try
            {
                var updatebook = new BookDTO()
                {
                    id = bookDTO.id,
                    namebook = bookDTO.namebook,
                    quanlitystock = bookDTO.quanlitystock,
                    importprice = bookDTO.importprice,
                    retailprice = bookDTO.retailprice,
                    idcate = bookDTO.idcate,
                    idau = bookDTO.idau,
                    idpub = bookDTO.idpub
                };

                string requestUrl = $"{_apiUrl}/{bookDTO.id}";
                var content = new StringContent(JsonConvert.SerializeObject(updatebook), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PutAsync(requestUrl, content);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<bool> DeleteAsync(string id)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{id}";
                HttpResponseMessage response = await _httpClient.DeleteAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }
    }
}
