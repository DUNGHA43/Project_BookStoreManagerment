using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.UnitOfWork;

namespace WebAPI_BookStoreManagement.Services
{
    public class PublisherService : IPublisherService
    {
        private readonly IUnitOfWork _unitOfWork;

        public PublisherService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddPublisherAsync(Publisher publisher)
        {
            if (await _unitOfWork.Publisher.GetByIdAsync(publisher.id) != null)
                throw new Exception($"ID already exists!");

            await _unitOfWork.Publisher.AddAsync(publisher);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task DeletePublisherAsync(int id)
        {
            _unitOfWork.Publisher.DeleteAsync(id);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<Publisher>> GetAllPublisherAsync()
        {
            return await _unitOfWork.Publisher.GetAllAsync();
        }

        public async Task<Publisher> GetPublisherByIdAsync(int id)
        {
            return await _unitOfWork.Publisher.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Publisher>> SearchPubByName(string name)
        {
            return await _unitOfWork.Publisher.SearchPubByName(name);
        }

        public async Task UpdatePublisherAsync(Publisher publisher)
        {
            _unitOfWork.Publisher.UpdateAsync(publisher);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}
