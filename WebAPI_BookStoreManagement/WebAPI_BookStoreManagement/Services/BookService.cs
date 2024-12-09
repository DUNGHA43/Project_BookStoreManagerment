using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.UnitOfWork;

namespace WebAPI_BookStoreManagement.Services
{
    public class BookService : IBookService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddBookAsync(Book book)
        {
            if (await _unitOfWork.Books.GetByIdAsync(book.id) != null)
                throw new Exception($"ID already exists!");

            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeleteBookAsync(string id)
        {
            _unitOfWork.Books.DeleteAsync(id);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<Book>> GetAllBookAsync()
        {
            return await _unitOfWork.Books.GetAllAsync();
        }

        public async Task<Book> GetBookByIdAsync(string id)
        {
            return await _unitOfWork.Books.GetByIdAsync(id);
        }

        public async Task UpdateBookAsync(Book book)
        {
            _unitOfWork.Books.UpdateAsync(book);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
