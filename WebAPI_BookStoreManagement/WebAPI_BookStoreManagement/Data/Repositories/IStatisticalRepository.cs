namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public interface IStatisticalRepository
    {
        Task<IEnumerable<dynamic>> GetStatisticalReceiptsByYearAsync(int year);
        Task<IEnumerable<dynamic>> GetStatisticalInvoiceAsync();
        Task<IEnumerable<dynamic>> GetStatisticalRevenueAsync();
    }
}
