using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BookInvoiceDAL
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7273/api/BookInvoice";

        public BookInvoiceDAL()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<BookInvoiceDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(_apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var bookinvoice = JsonConvert.DeserializeObject<List<BookInvoiceDTO>>(responsebody);
                    return bookinvoice;
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

        public async Task<IEnumerable<BookInvoiceDTO>> GetByIdAsync(string id)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/id?id={id}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var bookinvoice = JsonConvert.DeserializeObject<List<BookInvoiceDTO>>(responsebody);
                    return bookinvoice;
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

        public async Task<decimal> GetTotalInvoiceAsync(string id)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/total/{id}";
                HttpResponseMessage responese = await _httpClient.GetAsync(requestUrl);

                if (responese.IsSuccessStatusCode)
                {
                    string result = await responese.Content.ReadAsStringAsync();

                    if (decimal.TryParse(result, out decimal total))
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

        public async Task<IEnumerable<dynamic>> StatisticalInvoiceByYearAsync(int year)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/reportbyyear/{year}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var report = JsonConvert.DeserializeObject<List<dynamic>>(responsebody);
                    return report;
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

        public async Task<IEnumerable<dynamic>> StatisticalInvoiceByMonthAsync(int month, int year)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/reportbymonth/{month},{year}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var report = JsonConvert.DeserializeObject<List<dynamic>>(responsebody);
                    return report;
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

        public async Task<IEnumerable<dynamic>> StatisticalInvoiceByQuaterAsync(int quater, int year)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/reportbyquater/{quater},{year}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var report = JsonConvert.DeserializeObject<List<dynamic>>(responsebody);
                    return report;
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

        public async Task<IEnumerable<dynamic>> StatisticalRevenueByYearAsync(int year)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/revenuebyyear/{year}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var report = JsonConvert.DeserializeObject<List<dynamic>>(responsebody);
                    return report;
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

        public async Task<IEnumerable<dynamic>> StatisticalRevenueByMonthAsync(int month, int year)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/revenuebymonth/{month},{year}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var report = JsonConvert.DeserializeObject<List<dynamic>>(responsebody);
                    return report;
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

        public async Task<IEnumerable<dynamic>> StatisticalRevenueByQuaterAsync(int quater, int year)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/revenuebyquater/{quater},{year}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var report = JsonConvert.DeserializeObject<List<dynamic>>(responsebody);
                    return report;
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

        public async Task<bool> AddAsync(BookInvoiceDTO bookInvoiceDTO)
        {
            try
            {
                var newbookinvoice = new BookInvoiceDTO()
                {
                    id = bookInvoiceDTO.id,
                    saledate = bookInvoiceDTO.saledate,
                    idstaff = bookInvoiceDTO.idstaff,
                    totalprice = bookInvoiceDTO.totalprice
                };

                var content = new StringContent(JsonConvert.SerializeObject(newbookinvoice), Encoding.UTF8, "application/json");
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

        public async Task<bool> UpdateAsync(BookInvoiceDTO bookInvoiceDTO)
        {
            try
            {
                var updatebookinvoice = new BookInvoiceDTO()
                {
                    id = bookInvoiceDTO.id,
                    saledate = bookInvoiceDTO.saledate,
                    idstaff = bookInvoiceDTO.idstaff,
                    totalprice = bookInvoiceDTO.totalprice
                };

                string requestUrl = $"{_apiUrl}/{bookInvoiceDTO.id}";
                var content = new StringContent(JsonConvert.SerializeObject(updatebookinvoice), Encoding.UTF8, "application/json");
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
