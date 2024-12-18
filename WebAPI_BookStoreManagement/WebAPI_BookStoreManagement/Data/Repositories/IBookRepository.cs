using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<IEnumerable<Book>> GetAllBooksByPublisherAsync(int? idpub);
        Task<IEnumerable<Book>> SearchBooksByPublisherAsync(int? idpub, string namebook);
        Task<IEnumerable<Book>> SearchBooksByNameAsync(string namebook);
        Task<IEnumerable<Book>> SearchBookAsync(string? namebook, string? cate, string? pub, string? author);
        Task<int?> GetQuanlityBook(string? id);
    }
}
