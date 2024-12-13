using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookReceiptDAL
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7273/api/BookReceipt";

        public BookReceiptDAL()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<BookReceiptDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(_apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var bookrecipt = JsonConvert.DeserializeObject<List<BookReceiptDTO>>(responsebody);
                    return bookrecipt;
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

        public async Task<IEnumerable<BookReceiptDTO>> GetByIdAsync(string id)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{id}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var bookrecipt = JsonConvert.DeserializeObject<List<BookReceiptDTO>>(responsebody);
                    return bookrecipt;
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

        public async Task<decimal> GetTotalReceiptAsync(string id)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/total/{id}";
                HttpResponseMessage responese = await _httpClient.GetAsync(requestUrl);

                if (responese.IsSuccessStatusCode)
                {
                    string result = await responese.Content.ReadAsStringAsync();

                    if(decimal.TryParse(result, out decimal total))
                    {
                        return total;
                    }
                    return 0;
                }
                else
                {
                    string err = await responese.Content.ReadAsStringAsync();
                    throw new Exception(err);
                }
            }
            catch (Exception e)
            {

                throw new Exception(e.Message);
            }
        }

        public async Task<bool> AddAsync(BookReceiptDTO bookReceiptDTO)
        {
            try
            {
                var newbookreceipt = new BookReceiptDTO()
                {
                    id = bookReceiptDTO.id,
                    dateentry = bookReceiptDTO.dateentry,
                    idpublisher = bookReceiptDTO.idpublisher,
                    idstaff = bookReceiptDTO.idstaff,
                    totalprice = bookReceiptDTO.totalprice
                };

                var content = new StringContent(JsonConvert.SerializeObject(newbookreceipt), Encoding.UTF8, "application/json");
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

        public async Task<bool> UpdateAsync(BookReceiptDTO bookReceiptDTO)
        {
            try
            {
                var updatebookreceipt = new BookReceiptDTO()
                {
                    id = bookReceiptDTO.id,
                    dateentry = bookReceiptDTO.dateentry,
                    idpublisher = bookReceiptDTO.idpublisher,
                    idstaff = bookReceiptDTO.idstaff,
                    totalprice = bookReceiptDTO.totalprice
                };

                string requestUrl = $"{_apiUrl}/{bookReceiptDTO.id}";
                var content = new StringContent(JsonConvert.SerializeObject(updatebookreceipt), Encoding.UTF8, "application/json");
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
