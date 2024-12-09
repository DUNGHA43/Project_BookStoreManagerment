using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public interface IBookReceiptDetailRepository : IRepository<BookReceiptDetail>
    {
        Task<float> GetImportPriceBookIdAsync(string idbook);
        Task DeleteBookAsync(object idbookreceipts, object idbook);
        Task<BookReceiptDetail> GetBookReceiptByIdsAsync(object idbookreceipt, object idbook); 
        Task<IEnumerable<BookReceiptDetail>> GetAllBookReceiptDetailsByIdAsync(string idbookreceipt);
    }
}
