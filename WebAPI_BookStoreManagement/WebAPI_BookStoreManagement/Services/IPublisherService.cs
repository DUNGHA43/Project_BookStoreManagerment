using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Services
{
    public interface IPublisherService
    {
        Task<IEnumerable<Publisher>> GetAllPublisherAsync();
        Task<Publisher> GetPublisherByIdAsync(int id);
        Task AddPublisherAsync(Publisher publisher);
        Task UpdatePublisherAsync(Publisher publisher);
        Task DeletePublisherAsync(int id);
        Task<IEnumerable<Publisher>> SearchPubByName(string name);
    }
}
