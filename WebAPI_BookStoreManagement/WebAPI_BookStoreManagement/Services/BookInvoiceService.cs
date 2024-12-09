﻿using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.UnitOfWork;

namespace WebAPI_BookStoreManagement.Services
{
    public class BookInvoiceService : IBookInvoiceService
    {
        private readonly IUnitOfWork _unitOfWork;

        public BookInvoiceService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task AddBookInvoiceAsync(BookInvoice bookinvoice)
        {
            if (await GetBookInvoiceById(bookinvoice.id) != null)
                throw new Exception("ID already exists!");

            await _unitOfWork.BookInvoice.AddAsync(bookinvoice);
            await _unitOfWork.SaveChangeAsync();
                
        }

        public async Task DeleteBookInvoiceAsync(string id)
        {
            _unitOfWork.BookInvoice.DeleteAsync(id);
            await _unitOfWork.SaveChangeAsync();
        }

        public async Task<IEnumerable<BookInvoice>> GetAllBookInvoiceAsync()
        {
            return await _unitOfWork.BookInvoice.GetAllAsync();
        }

        public async Task<BookInvoice> GetBookInvoiceById(string id)
        {
            return await _unitOfWork.BookInvoice.GetByIdAsync(id);
        }

        public async Task UpdateBookInvoiceAsync(BookInvoice bookinvoice)
        {
            _unitOfWork.BookInvoice.UpdateAsync(bookinvoice);
            await _unitOfWork.SaveChangeAsync();
        }
    }
}