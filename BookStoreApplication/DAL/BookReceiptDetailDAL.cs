using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookReceiptDetailDAL
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7273/api/BookReceiptDetail";

        public BookReceiptDetailDAL()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<BookReceiptDetailDTO>> GetAllBRAsync(string idreceipt)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{idreceipt}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var bookreceiptdetail = JsonConvert.DeserializeObject<List<BookReceiptDetailDTO>>(responsebody);
                    return bookreceiptdetail;
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

        public async Task<bool> AddBookInDetailAsync(BookReceiptDetailDTO detail)
        {
            try
            {
                var _detail = new BookReceiptDetailDTO()
                {
                    idreceipt = detail.idreceipt,
                    idbook = detail.idbook,
                    quanlity = detail.quanlity,
                    totalprice = detail.totalprice
                };

                var content = new StringContent(JsonConvert.SerializeObject(_detail), Encoding.UTF8, "application/json");
                HttpResponseMessage response = await _httpClient.PostAsync(_apiUrl, content);
                if (response.IsSuccessStatusCode)
                {
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<bool> DeleteBookInDetailAsync(string idreceipt, string idbook)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{idreceipt}, {idbook}";
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
