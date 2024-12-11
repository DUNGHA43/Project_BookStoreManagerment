using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.UnitOfWork;

namespace WebAPI_BookStoreManagement.Services
{
    public class StaffService : IStaffService
    {
        private readonly IUnitOfWork _unitOfWork;

        public StaffService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddStaffAsync(Staff staff)
        {
            if(await _unitOfWork.Staff.GetByIdAsync(staff.id) != null)
            {
                throw new Exception("ID already exists!");
            }
            await _unitOfWork.Staff.AddAsync(staff);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteStaffAsync(string id)
        {
            _unitOfWork.Staff.DeleteAsync(id);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<Staff>> GetAllStaffAsync()
        {
            return await _unitOfWork.Staff.GetAllAsync();
        }

        public async Task<Staff> GetStaffByIdAsync(string id)
        {
            return await _unitOfWork.Staff.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Staff>> SearchStaffByNameAsync(string name)
        {
            return await _unitOfWork.Staff.SearchByNameAsync(name);
        }

        public async Task UpdateStaffAsync(Staff staff)
        {
            _unitOfWork.Staff.UpdateAsync(staff);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
