
using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public interface IPublisherRepository : IRepository<Publisher>
    {
        Task<IEnumerable<Publisher>> SearchPubByName(string name);
    }
}
