using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class StaffBLL
    {
        private readonly StaffDAL _staffDAL;

        public StaffBLL()
        {
            _staffDAL = new StaffDAL();
        }

        public async Task<IEnumerable<StaffDTO>> ShowAllStaffAsync()
        {
            return await _staffDAL.GetAllStaffAsync();
        }

        public async Task<IEnumerable<StaffDTO>> SearchStaffByName(string name)
        {
            return await _staffDAL.GetByNameAsync(name);
        }

        public async Task<bool> AddStaffAsync(StaffDTO staffDTO)
        {
            return await _staffDAL.AddAsync(staffDTO);
        }

        public async Task<bool> UpdateStaffAsync(StaffDTO staffDTO)
        {
            return await _staffDAL.UpdateAsync(staffDTO);
        }

        public async Task<bool> DeleteStaffAsync(string id)
        {
            return await _staffDAL.DeleteAsync(id);
        }
    }
}
