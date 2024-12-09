namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public interface IRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAllAsync();
        Task<T> GetByIdAsync(object id);
        Task AddAsync(T entity);
        void UpdateAsync(T entity);
        void DeleteAsync(object id);
        Task SaveChangeAsync();

    }
}
