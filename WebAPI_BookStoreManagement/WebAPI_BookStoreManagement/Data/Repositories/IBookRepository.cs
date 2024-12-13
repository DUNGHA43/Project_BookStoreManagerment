using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<IEnumerable<Book>> GetAllBooksByPublisherAsync(int? idpub);
        Task<IEnumerable<Book>> SearchBooksByPublisherAsync(int? idpub, string namebook);
    }
}
