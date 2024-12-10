using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
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
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var userAccount = JsonConvert.DeserializeObject<AccountDTO>(responsebody);
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

        public async Task<IEnumerable<AccountDTO>> GetAllAccountAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(_apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var accounts = JsonConvert.DeserializeObject<List<AccountDTO>>(responsebody);
                    return accounts;
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

        public async Task<IEnumerable<AccountDTO>> GetByUsername(string username)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{username}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var accounts = JsonConvert.DeserializeObject<List<AccountDTO>>(responsebody);
                    return accounts;
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

        public async Task<bool> AddAsync(AccountDTO accountDTO)
        {
            try
            {
                var newaccount = new AccountDTO
                {
                    username = accountDTO.username,
                    passw = accountDTO.passw,
                    roleacc = accountDTO.roleacc,
                    idstaff = accountDTO.idstaff
                };

                var content = new StringContent(JsonConvert.SerializeObject(newaccount), Encoding.UTF8, "application/json");
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

        public async Task<bool> UpdateAsync(AccountDTO accountDTO)
        {
            try
            {
                var updateAccount = new AccountDTO
                {
                    username = accountDTO.username,
                    passw = accountDTO.passw,
                    roleacc = accountDTO.roleacc,
                    idstaff = accountDTO.idstaff
                };

                string requestUrl = $"{_apiUrl}/{accountDTO.username}";
                var content = new StringContent(JsonConvert.SerializeObject(updateAccount), Encoding.UTF8, "application/json");
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

        public async Task<bool> DeleteAsync(string username)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{username}";
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
