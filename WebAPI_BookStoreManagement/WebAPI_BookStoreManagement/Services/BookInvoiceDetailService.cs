using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.UnitOfWork;

namespace WebAPI_BookStoreManagement.Services
{
    public class BookInvoiceDetailService : IBookInvoiceDetailService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookInvoiceDetailService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddBookInvoiceDetailAsync(BookInvoiceDetail bookinvoicedetail)
        {
            var _bookinvoicedetail = await GetBookInvoiceDetailByIdAsync(bookinvoicedetail.idinvoice, bookinvoicedetail.idbook);
            if (_bookinvoicedetail == null)
            {
                float? total = await CalculateTotalAsync(bookinvoicedetail.idbook, bookinvoicedetail.quanlity);
                bookinvoicedetail.totalprice = Convert.ToDecimal(total);
                await _unitOfWork.BookInvoiceDetail.AddAsync(bookinvoicedetail);
            }
            else
            {
                int? quanlity = await _unitOfWork.BookInvoiceDetail.GetQuanlityBookInDetailAsync
                    (bookinvoicedetail.idinvoice, bookinvoicedetail.idbook);

                if (quanlity > 0)
                {
                    bookinvoicedetail.quanlity = quanlity + 1;
                    float? total = await CalculateTotalAsync(bookinvoicedetail.idbook, bookinvoicedetail.quanlity);
                    bookinvoicedetail.totalprice = Convert.ToDecimal(total);
                }

                _unitOfWork.BookInvoiceDetail.UpdateAsync(bookinvoicedetail);
            }

            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<float?> CalculateTotalAsync(string idbook, int? quanlity)
        {
            var retailprice = await _unitOfWork.BookInvoiceDetail.GetRetailPriceBookAsync(idbook);

            return retailprice * quanlity;
        }

        public async Task DeleteBookInvoiceDetailAsync(string idinvoice, string idbook)
        {
            await _unitOfWork.BookInvoiceDetail.DeleteBookAsync(idinvoice, idbook);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<BookInvoiceDetail>> GetAllBookInvoiceDetailAsync(string idbookinvoice)
        {
            return await _unitOfWork.BookInvoiceDetail.GetAllBookInvoiceDetailsByIdAsync(idbookinvoice);
        }

        public async Task<BookInvoiceDetail> GetBookInvoiceDetailByIdAsync(string idbookinvoice, string idbook)
        {
            return await _unitOfWork.BookInvoiceDetail.GetBookInvoiceByIdsAsync(idbookinvoice, idbook);
        }
    }
}
