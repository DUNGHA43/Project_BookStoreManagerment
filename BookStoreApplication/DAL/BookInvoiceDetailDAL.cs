using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookInvoiceDetailDAL
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7273/api/BookInvoiceDetail";

        public BookInvoiceDetailDAL()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<BookInvoiceDetailDTO>> GetAllBIAsync(string idinvoice)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{idinvoice}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var bookinvoicedetail = JsonConvert.DeserializeObject<List<BookInvoiceDetailDTO>>(responsebody);
                    return bookinvoicedetail;
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

        public async Task<bool> AddBookInDetailAsync(BookInvoiceDetailDTO detail)
        {
            try
            {
                var _detail = new BookInvoiceDetailDTO()
                {
                    idinvoice = detail.idinvoice,
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

        public async Task<bool> DeleteBookInDetailAsync(string idinvoice, string idbook)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{idinvoice},{idbook}";
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
