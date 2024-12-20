using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public interface IBookReceiptRepository : IRepository<BookReceipt>
    {
        Task<IEnumerable<BookReceipt>> SearchBookReceiptsByIdAsync(string id);
        Task<decimal?> CalculateReceiptTotalAsync(string id);
        Task<IEnumerable<dynamic>> GetStatisticalReceiptsByYearAsync(int year);
        Task<IEnumerable<dynamic>> GetStatisticalReceiptsByQuaterAsync(int quater,int year);
        Task<IEnumerable<dynamic>> GetStatisticalReceiptsByMonthAsync(int month,int year);
    }
}
