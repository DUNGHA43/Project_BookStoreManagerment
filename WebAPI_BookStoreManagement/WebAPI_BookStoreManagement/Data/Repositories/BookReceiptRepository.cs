using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public class BookReceiptRepository : Repository<BookReceipt>, IBookReceiptRepository
    {
        private DBBookStoreContext _context;

        public BookReceiptRepository(DBBookStoreContext context) : base(context)
        {
            _context = context;
        }

        public async Task<decimal?> CalculateReceiptTotalAsync(string id)
        {
            var total = await _context.bookreceiptsdetails
                                      .Where(totaldetail => totaldetail.idreceipt == id)
                                      .SumAsync(totaldetail => totaldetail.totalprice);

            return total ?? -1;
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalReceiptsByQuaterAsync(int quater, int year)
        {
            var query = from receipts in _context.bookreceipts
                        join detail in _context.bookreceiptsdetails on receipts.id equals detail.idreceipt
                        where receipts.dateentry.HasValue && receipts.dateentry.Value.Year == year
                              && (receipts.dateentry.Value.Month - 1) / 3 + 1 == quater
                        group new { receipts, detail } by new
                        {
                            dateentry = receipts.dateentry,
                            idreceipt = detail.idreceipt
                        } into grouped
                        select new
                        {
                            IDReceipts = grouped.Key.idreceipt,
                            DateEntry = grouped.Key.dateentry,
                            Quanlity = grouped.Sum(d => d.detail.quanlity),
                            TotalPriceSum = grouped.Sum(r => r.receipts.totalprice)
                        };

            return query.ToList();
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalReceiptsByMonthAsync(int month, int year)
        {
            var query = from receipts in _context.bookreceipts
                        join detail in _context.bookreceiptsdetails on receipts.id equals detail.idreceipt
                        where receipts.dateentry.HasValue && receipts.dateentry.Value.Year == year
                              && receipts.dateentry.Value.Month == month
                        group new { receipts, detail } by new
                        {
                            dateentry = receipts.dateentry,
                            idreceipt = detail.idreceipt
                        } into grouped
                        select new
                        {
                            IDReceipts = grouped.Key.idreceipt,
                            DateEntry = grouped.Key.dateentry,
                            Quanlity = grouped.Sum(d => d.detail.quanlity),
                            TotalPriceSum = grouped.Sum(r => r.receipts.totalprice)
                        };

            return query.ToList();
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalReceiptsByYearAsync(int year)
        {
            var query = from receipts in _context.bookreceipts
                        join detail in _context.bookreceiptsdetails on receipts.id equals detail.idreceipt
                        where receipts.dateentry.HasValue && receipts.dateentry.Value.Year == year
                        group new { receipts, detail } by new
                        {
                            dateentry = receipts.dateentry,
                            idreceipt = detail.idreceipt
                        } into grouped
                        select new
                        {
                            IDReceipts = grouped.Key.idreceipt,
                            DateEntry = grouped.Key.dateentry,
                            Quanlity = grouped.Sum(d => d.detail.quanlity),
                            TotalPriceSum = grouped.Sum(r => r.receipts.totalprice)
                        };

            return query.ToList();
        }

        public async Task<IEnumerable<BookReceipt>> SearchBookReceiptsByIdAsync(string id)
        {
            return await _dbSet.Where(br => br.id.Contains(id)).ToListAsync();
        }
    }
}
