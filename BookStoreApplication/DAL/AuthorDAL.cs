using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AuthorDAL
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7273/api/Author";

        public AuthorDAL()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<AuthorDTO>> GetAllAuthorAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(_apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var authors = JsonConvert.DeserializeObject<List<AuthorDTO>>(responsebody);
                    return authors;
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

        public async Task<IEnumerable<AuthorDTO>> SearchAuthorByName(string name)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{name}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var authors = JsonConvert.DeserializeObject<List<AuthorDTO>>(responsebody);
                    return authors;
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

        public async Task<bool> AddAsync(AuthorDTO author)
        {
            try
            {
                var newAuthor = new AuthorDTO()
                {
                    id = author.id,
                    fullname = author.fullname,
                    addre = author.addre
                };

                var content = new StringContent(JsonConvert.SerializeObject(newAuthor), Encoding.UTF8, "application/json");
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

        public async Task<bool> UpdateAsync(AuthorDTO author)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{author.id}";
                var updateAuthor = new AuthorDTO()
                {
                    id = author.id,
                    fullname = author.fullname,
                    addre = author.addre
                };

                var content = new StringContent(JsonConvert.SerializeObject(updateAuthor), Encoding.UTF8, "application/json");
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
