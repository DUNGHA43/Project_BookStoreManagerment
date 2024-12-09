using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.UnitOfWork;

namespace WebAPI_BookStoreManagement.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IUnitOfWork _unitOfWork;

        public AuthorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddAuthorAsync(Author author)
        {
            if (await _unitOfWork.Author.GetByIdAsync(author.id) != null)
                throw new Exception($"ID already exists!");

            await _unitOfWork.Author.AddAsync(author);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteAuthorAsync(int id)
        {
            _unitOfWork.Author.DeleteAsync(id);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<Author>> GetAllAuthorAsync()
        {
            return await _unitOfWork.Author.GetAllAsync();
        }

        public async Task<Author> GetAuthorByIdAsync(int id)
        {
            return await _unitOfWork.Author.GetByIdAsync(id);
        }

        public async Task UpdateAuthorAsync(Author author)
        {
            _unitOfWork.Author.UpdateAsync(author);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
