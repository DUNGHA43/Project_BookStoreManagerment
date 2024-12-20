using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.UnitOfWork;

namespace WebAPI_BookStoreManagement.Services
{
    public class BookReceiptServices : IBookReceiptServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookReceiptServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddBookReceiptAsync(BookReceipt? bookreceipt)
        {
            if (await _unitOfWork.BooksReceipt.GetByIdAsync(bookreceipt.id) != null)
                throw new Exception($"ID {bookreceipt.id} already exists");

            await _unitOfWork.BooksReceipt.AddAsync(bookreceipt);
            await _unitOfWork.BooksReceipt.SaveChangeAsync();
        }

        public async Task<decimal?> CalculateReceiptTotalAsync(string id)
        {
            return await _unitOfWork.BooksReceipt.CalculateReceiptTotalAsync(id);
        }

        public async Task DeleteBookReceiptAsync(string id)
        {
            _unitOfWork.BooksReceipt.DeleteAsync(id);
            await _unitOfWork.BooksReceipt.SaveChangeAsync();
        }

        public async Task<IEnumerable<BookReceipt>> GetAllBookReceiptAsync()
        {
            return await _unitOfWork.BooksReceipt.GetAllAsync();
        }

        public async Task<BookReceipt> GetBookReceiptById(string id)
        {
            return await _unitOfWork.BooksReceipt.GetByIdAsync(id);
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalReceiptsByMonthAsync(int month, int year)
        {
            return await _unitOfWork.BooksReceipt.GetStatisticalReceiptsByMonthAsync(month, year);
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalReceiptsByQuaterAsync(int quater, int year)
        {
            return await _unitOfWork.BooksReceipt.GetStatisticalReceiptsByQuaterAsync(quater, year);
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalReceiptsByYearAsync(int year)
        {
            return await _unitOfWork.BooksReceipt.GetStatisticalReceiptsByYearAsync(year);
        }

        public async Task<IEnumerable<BookReceipt>> SearchBookReceiptsById(string id)
        {
            return await _unitOfWork.BooksReceipt.SearchBookReceiptsByIdAsync(id);
        }

        public async Task UpdateBookReceiptAsync(BookReceipt bookreceipt)
        {
            _unitOfWork.BooksReceipt.UpdateAsync(bookreceipt);
            await _unitOfWork.BooksReceipt.SaveChangeAsync();
        }
    }
}
