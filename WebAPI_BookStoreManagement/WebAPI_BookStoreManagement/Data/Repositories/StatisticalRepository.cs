using Microsoft.EntityFrameworkCore;
using System.Text.RegularExpressions;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public class StatisticalRepository : IStatisticalRepository
    {
        private readonly DBBookStoreContext _context;

        public StatisticalRepository(DBBookStoreContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<dynamic>> GetStatisticalInvoiceAsync()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalReceiptsByYearAsync(int year)
        {
            var query = from receipts in _context.bookreceipts
                        where receipts.dateentry.HasValue && receipts.dateentry.Value.Year == year
                        group receipts by receipts.dateentry.Value into grouped
                        select new
                        {
                            DateEntry = grouped.Key,
                            TotalPriceSum = grouped.Sum(r => r.totalprice)
                        };

            return query.ToList();
        }

        public Task<IEnumerable<dynamic>> GetStatisticalRevenueAsync()
        {
            throw new NotImplementedException();
        }
    }
}
