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

        public async Task UpdateBookReceiptAsync(BookReceipt bookreceipt)
        {
            _unitOfWork.BooksReceipt.UpdateAsync(bookreceipt);
            await _unitOfWork.BooksReceipt.SaveChangeAsync();
        }
    }
}
