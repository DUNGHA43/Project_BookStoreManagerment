using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class StaffDAL
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiUrl = "https://localhost:7273/api/Staff";

        public StaffDAL()
        {
            _httpClient = new HttpClient();
        }

        public async Task<IEnumerable<StaffDTO>> GetAllStaffAsync()
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(_apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var staffs = JsonConvert.DeserializeObject<List<StaffDTO>>(responsebody);
                    return staffs;
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

        public async Task<IEnumerable<StaffDTO>> GetByNameAsync(string name)
        {
            try
            {
                string requestUrl = $"{_apiUrl}/{name}";
                HttpResponseMessage response = await _httpClient.GetAsync(requestUrl);

                if (response.IsSuccessStatusCode)
                {
                    string responsebody = await response.Content.ReadAsStringAsync();
                    var staffs = JsonConvert.DeserializeObject<List<StaffDTO>>(responsebody);
                    return staffs;
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

        public async Task<bool> AddAsync(StaffDTO staffDTO)
        {
            try
            {
                var newStaff = new StaffDTO() { 
                    id = staffDTO.id,
                    fullname = staffDTO.fullname,
                    birthday = staffDTO.birthday,
                    identification = staffDTO.identification,
                    phonenumber = staffDTO.phonenumber,
                    addre = staffDTO.addre,
                    workschedule = staffDTO.workschedule
                };

                var content = new StringContent(JsonConvert.SerializeObject(newStaff), Encoding.UTF8, "application/json");
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

        public async Task<bool> UpdateAsync(StaffDTO staffDTO)
        {
            try
            {
                var updateStaff = new StaffDTO()
                {
                    id = staffDTO.id,
                    fullname = staffDTO.fullname,
                    birthday = staffDTO.birthday,
                    identification = staffDTO.identification,
                    phonenumber = staffDTO.phonenumber,
                    addre = staffDTO.addre,
                    workschedule = staffDTO.workschedule
                };

                string requestUrl = $"{_apiUrl}/{staffDTO.id}";
                var content = new StringContent(JsonConvert.SerializeObject(updateStaff), Encoding.UTF8, "application/json");
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
