using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PublisherDAL
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7273/api/Publisher";

        public PublisherDAL()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<PublisherDTO>> GetAllAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(_apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var publisher = JsonConvert.DeserializeObject<List<PublisherDTO>>(responsebody);
                    return publisher;
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

        public async Task<IEnumerable<PublisherDTO>> SearchPublisherByNameAsync(string name)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{ name}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var publisher = JsonConvert.DeserializeObject<List<PublisherDTO>>(responsebody);
                    return publisher;
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

        public async Task<bool> AddAsync(PublisherDTO publisher)
        {
            try
            {
                var newpublisher = new PublisherDTO()
                {
                    id = publisher.id,
                    namepublisher = publisher.namepublisher,
                    phonenumber = publisher.phonenumber,
                    addre = publisher.addre
                };

                var content = new StringContent(JsonConvert.SerializeObject(newpublisher), Encoding.UTF8, "application/json");
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

        public async Task<bool> UpdateAsync(PublisherDTO publisher)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{publisher.id}";
                var updatepublisher = new PublisherDTO()
                {
                    id = publisher.id,
                    namepublisher = publisher.namepublisher,
                    phonenumber = publisher.phonenumber,
                    addre = publisher.addre
                };

                var content = new StringContent(JsonConvert.SerializeObject(updatepublisher), Encoding.UTF8, "application/json");
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

        public async Task<bool> DeleteAsync(int? id)
        {
            try
            {
                string requsetUrl = $"{_apiUrl}/{id}";
                HttpResponseMessage response = await _httpClient.DeleteAsync(requsetUrl);

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
