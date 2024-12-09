using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAL
{
    public class AccountDAL
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7273/api/Account";

        public AccountDAL()
        {
            _httpClient = new HttpClient();
        }

        public async Task<AccountDTO> LoginAsync(string username, string password)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{username}, {password}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string reponsebody = await response.Content.ReadAsStringAsync();
                    var userAccount = JsonSerializer.Deserialize<AccountDTO>(reponsebody, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    });
                    return userAccount;
                }
                else
                {
                    string errorResponse = await response.Content.ReadAsStringAsync();
                    throw new Exception(errorResponse);
                }
            }
            catch (Exception e)
            {

                throw new Exception($"Error during login: {e.Message}");
            }
        }
    }
}
