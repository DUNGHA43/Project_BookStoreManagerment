﻿using WebAPI_BookManagement.Model;
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
                await _unitOfWork.BookInvoiceDetail.AddAsync(bookinvoicedetail);
            }
            else
            {
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
