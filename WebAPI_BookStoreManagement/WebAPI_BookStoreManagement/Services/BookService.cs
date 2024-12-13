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

        public async Task<IEnumerable<Book>> GetAllBookByPublisherAsync(int idpub)
        {
            return await _unitOfWork.Books.GetAllBooksByPublisherAsync(idpub);
        }

        public async Task<Book> GetBookByIdAsync(string id)
        {
            return await _unitOfWork.Books.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Book>> SearchBookAsync(string namebook, string cate, string pub, string author)
        {
            return await _unitOfWork.Books.SearchBookAsync(namebook, cate, pub, author);
        }

        public async Task<IEnumerable<Book>> SearchBookByPublisherAsync(int idpub, string namebook)
        {
            return await _unitOfWork.Books.SearchBooksByPublisherAsync(idpub, namebook);
        }

        public async Task<IEnumerable<Book>> SearchBooksByNameAsync(string namebook)
        {
            return await _unitOfWork.Books.SearchBooksByNameAsync(namebook);
        }

        public async Task UpdateBookAsync(Book book)
        {
            _unitOfWork.Books.UpdateAsync(book);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
