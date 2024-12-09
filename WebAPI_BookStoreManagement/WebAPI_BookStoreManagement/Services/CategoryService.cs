using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.UnitOfWork;

namespace WebAPI_BookStoreManagement.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddCategoryAsync(Category? category)
        {
            if (await _unitOfWork.Categories.GetByIdAsync(category.id) != null)
                throw new Exception($"ID already exists!");

            await _unitOfWork.Categories.AddAsync(category);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteCategoryAsync(int id)
        {
            _unitOfWork.Categories.DeleteAsync(id);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<Category>> GetAllCategoryAsync()
        {
            return await _unitOfWork.Categories.GetAllAsync();
        }

        public async Task<Category> GetCategoryByIdAsync(int id)
        {
            return await _unitOfWork.Categories.GetByIdAsync(id);
        }

        public async Task UpdateCategoryAsync(Category category)
        {
            _unitOfWork.Categories.UpdateAsync(category);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
