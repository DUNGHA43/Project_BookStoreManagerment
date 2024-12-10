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
    }
}
