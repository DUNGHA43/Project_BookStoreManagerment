using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBookAsync();
        Task<Book> GetBookByIdAsync(string id);
        Task AddBookAsync(Book book);
        Task UpdateBookAsync(Book book);
        Task DeleteBookAsync(string id);
    }
}
