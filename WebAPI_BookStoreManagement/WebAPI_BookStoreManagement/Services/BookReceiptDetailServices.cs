﻿using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.UnitOfWork;

namespace WebAPI_BookStoreManagement.Services
{
    public class BookReceiptDetailServices : IBookReceiptDetailServices
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookReceiptDetailServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddBookReceiptDetailAsync(BookReceiptDetail bookreceiptdetail)
        {
            var _bookreceiptdetail = await GetBookReceiptDetailByIdAsync(bookreceiptdetail.idreceipt, bookreceiptdetail.idbook);
            var book = await _unitOfWork.Books.GetByIdAsync(bookreceiptdetail.idbook);
            if (_bookreceiptdetail != null)
            {
                _unitOfWork.BookReceiptDetail.UpdateAsync(bookreceiptdetail);
            }
            else
            {
                book.quanlitystock += bookreceiptdetail.quanlity;
                _unitOfWork.Books.UpdateAsync(book);

                await _unitOfWork.BookReceiptDetail.AddAsync(bookreceiptdetail);
            }

            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<float?> CalculateTotalAsync(string idbook, int? quanlity)
        {
            var importprice = await _unitOfWork.BookReceiptDetail.GetImportPriceBookIdAsync(idbook);

            return importprice * quanlity;
        }

        public async Task DeleteBookReceiptDetailAsync(string idreceipt, string idbook)
        {
            var book = await _unitOfWork.Books.GetByIdAsync(idbook);
            var detail = await GetBookReceiptDetailByIdAsync(idreceipt, idbook);
            book.quanlitystock -= detail.quanlity;
            await _unitOfWork.BookReceiptDetail.DeleteBookAsync(idreceipt, idbook);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<BookReceiptDetail>> GetAllBookReceiptDetailAsync(string idbookreceipt)
        {
            return await _unitOfWork.BookReceiptDetail.GetAllBookReceiptDetailsByIdAsync(idbookreceipt);
        }

        public async Task<BookReceiptDetail> GetBookReceiptDetailByIdAsync(string idbookreceipt, string idbook)
        {
            return await _unitOfWork.BookReceiptDetail.GetBookReceiptByIdsAsync(idbookreceipt, idbook);
        }
    }
}
