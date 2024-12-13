using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Services
{
    public interface IBookService
    {
        Task<IEnumerable<Book>> GetAllBookAsync();
        Task<IEnumerable<Book>> GetAllBookByPublisherAsync(int idpub);
        Task<IEnumerable<Book>> SearchBookByPublisherAsync(int idpub, string namebook);
        Task<IEnumerable<Book>> SearchBooksByNameAsync(string namebook);
        Task<IEnumerable<Book>> SearchBookAsync(string namebook, string cate, string pub, string author);
        Task<Book> GetBookByIdAsync(string id);
        Task AddBookAsync(Book book);
        Task UpdateBookAsync(Book book);
        Task DeleteBookAsync(string id);
    }
}
