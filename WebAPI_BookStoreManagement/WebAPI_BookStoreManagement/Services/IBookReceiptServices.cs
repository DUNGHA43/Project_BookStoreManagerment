﻿using WebAPI_BookManagement.Model;

namespace WebAPI_BookStoreManagement.Services
{
    public interface IBookReceiptServices
    {
        Task<IEnumerable<BookReceipt>> GetAllBookReceiptAsync();
        Task<BookReceipt> GetBookReceiptById(string id);
        Task AddBookReceiptAsync(BookReceipt bookreceipt);
        Task UpdateBookReceiptAsync(BookReceipt bookreceipt);
        Task DeleteBookReceiptAsync(string id);
        Task<IEnumerable<BookReceipt>> SearchBookReceiptsById(string id);
        Task<decimal?> CalculateReceiptTotalAsync(string id);
    }
}
