using Microsoft.EntityFrameworkCore;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.Data.DBContext;

namespace WebAPI_BookStoreManagement.Data.Repositories
{
    public class BookInvoiceRepository : Repository<BookInvoice>, IBookInvoiceRepository
    {
        private readonly DBBookStoreContext _context;

        public BookInvoiceRepository(DBBookStoreContext context) : base(context) 
        {
            _context = context;
        }

        public async Task<decimal?> CalculateInvoiceTotalAsync(string id)
        {
            var total = await _context.bookinvoicedetails
                                        .Where(totaldetail => totaldetail.idinvoice == id)
                                        .SumAsync(totaldetail => totaldetail.totalprice);

            return total ?? -1;
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalInvoiceByMonthAsync(int month, int year)
        {
            var query = from invoice in _context.bookinvoices
                        join detail in _context.bookinvoicedetails on invoice.id equals detail.idinvoice
                        where invoice.saledate.HasValue && invoice.saledate.Value.Year == year
                              && invoice.saledate.Value.Month == month
                        group new { invoice, detail } by new
                        {
                            dateentry = invoice.saledate,
                            idinvoice = detail.idinvoice
                        } into grouped
                        select new
                        {
                            IDInvoice = grouped.Key.idinvoice,
                            DateEntry = grouped.Key.dateentry,
                            Quanlity = grouped.Sum(d => d.detail.quanlity),
                            TotalPriceSum = grouped.Sum(r => r.invoice.totalprice)
                        };

            return query.ToList();
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalInvoiceByQuaterAsync(int quater, int year)
        {
            var query = from invoice in _context.bookinvoices
                        join detail in _context.bookinvoicedetails on invoice.id equals detail.idinvoice
                        where invoice.saledate.HasValue && invoice.saledate.Value.Year == year
                              && (invoice.saledate.Value.Month - 1)/ 3 + 1 == quater
                        group new { invoice, detail } by new
                        {
                            dateentry = invoice.saledate,
                            idinvoice = detail.idinvoice
                        } into grouped
                        select new
                        {
                            IDInvoice = grouped.Key.idinvoice,
                            DateEntry = grouped.Key.dateentry,
                            Quanlity = grouped.Sum(d => d.detail.quanlity),
                            TotalPriceSum = grouped.Sum(r => r.invoice.totalprice)
                        };

            return query.ToList();
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalInvoiceByYearAsync(int year)
        {
            var query = from invoice in _context.bookinvoices
                        join detail in _context.bookinvoicedetails on invoice.id equals detail.idinvoice
                        where invoice.saledate.HasValue && invoice.saledate.Value.Year == year
                        group new { invoice, detail } by new
                        {
                            dateentry = invoice.saledate,
                            idreceipt = detail.idinvoice
                        } into grouped
                        select new
                        {
                            IDReceipts = grouped.Key.idreceipt,
                            DateEntry = grouped.Key.dateentry,
                            Quanlity = grouped.Sum(d => d.detail.quanlity),
                            TotalPriceSum = grouped.Sum(r => r.invoice.totalprice)
                        };

            return query.ToList();
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalRevenueByMonthAsync(int month, int year)
        {
            var query = from sale in (
                        from invoice in _context.bookinvoices
                        join detail in _context.bookinvoicedetails on invoice.id equals detail.idinvoice
                        where invoice.saledate.HasValue && invoice.saledate.Value.Year == year
                              && invoice.saledate.Value.Month == month
                        group new { invoice, detail } by invoice.saledate.Value.Date into grouped
                        select new
                        {
                            Date = grouped.Key,
                            Revenue = (decimal?)grouped.Sum(g => g.invoice.totalprice),
                            Cost = (decimal?)0
                        }
                        ).Union(
                            from receipt in _context.bookreceipts
                            join detail in _context.bookreceiptsdetails on receipt.id equals detail.idreceipt
                            where receipt.dateentry.HasValue && receipt.dateentry.Value.Year == year
                            && receipt.dateentry.Value.Month == month
                            group new { receipt, detail } by receipt.dateentry.Value.Date into grouped
                            select new
                            {
                                Date = grouped.Key,
                                Revenue = (decimal?)0,
                                Cost = (decimal?)grouped.Sum(g => g.receipt.totalprice)
                            }
                        )
                        group sale by sale.Date into grouped
                        select new
                        {
                            Date = grouped.Key,
                            TotalRevenue = grouped.Sum(g => g.Revenue),
                            TotalCost = grouped.Sum(g => g.Cost),
                            Profit = grouped.Sum(g => g.Revenue) - grouped.Sum(g => g.Cost)
                        };

            return query.ToList();
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalRevenueByQuaterAsync(int quater, int year)
        {
            var query = from sale in (
                        from invoice in _context.bookinvoices
                        join detail in _context.bookinvoicedetails on invoice.id equals detail.idinvoice
                        where invoice.saledate.HasValue && invoice.saledate.Value.Year == year
                              && (invoice.saledate.Value.Month - 1) / 3 + 1 == quater
                        group new { invoice, detail } by invoice.saledate.Value.Date into grouped
                        select new
                        {
                            Date = grouped.Key,
                            Revenue = (decimal?)grouped.Sum(g => g.invoice.totalprice),
                            Cost = (decimal?)0
                        }
                        ).Union(
                            from receipt in _context.bookreceipts
                            join detail in _context.bookreceiptsdetails on receipt.id equals detail.idreceipt
                            where receipt.dateentry.HasValue && receipt.dateentry.Value.Year == year
                            && (receipt.dateentry.Value.Month - 1) / 3 + 1 == quater
                            group new { receipt, detail } by receipt.dateentry.Value.Date into grouped
                            select new
                            {
                                Date = grouped.Key,
                                Revenue = (decimal?)0,
                                Cost = (decimal?)grouped.Sum(g => g.receipt.totalprice)
                            }
                        )
                        group sale by sale.Date into grouped
                        select new
                        {
                            Date = grouped.Key,
                            TotalRevenue = grouped.Sum(g => g.Revenue),
                            TotalCost = grouped.Sum(g => g.Cost),
                            Profit = grouped.Sum(g => g.Revenue) - grouped.Sum(g => g.Cost)
                        };

            return query.ToList();
        }

        public async Task<IEnumerable<dynamic>> GetStatisticalRevenueByYearAsync(int year)
        {
            var query = from sale in (
                        from invoice in _context.bookinvoices
                        join detail in _context.bookinvoicedetails on invoice.id equals detail.idinvoice
                        where invoice.saledate.HasValue && invoice.saledate.Value.Year == year
                        group new { invoice, detail } by invoice.saledate.Value.Date into grouped
                        select new
                        {
                            Date = grouped.Key,
                            Revenue = (decimal?)grouped.Sum(g => g.invoice.totalprice),
                            Cost = (decimal?)0
                        }
                        ).Union(
                            from receipt in _context.bookreceipts
                            join detail in _context.bookreceiptsdetails on receipt.id equals detail.idreceipt
                            where receipt.dateentry.HasValue && receipt.dateentry.Value.Year == year
                            group new { receipt, detail } by receipt.dateentry.Value.Date into grouped
                            select new
                            {
                                Date = grouped.Key,
                                Revenue = (decimal?)0,
                                Cost = (decimal?)grouped.Sum(g => g.receipt.totalprice)
                            }
                        )
                        group sale by sale.Date into grouped
                        select new
                        {
                            Date = grouped.Key,
                            TotalRevenue = grouped.Sum(g => g.Revenue),
                            TotalCost = grouped.Sum(g => g.Cost),
                            Profit = grouped.Sum(g => g.Revenue) - grouped.Sum(g => g.Cost)
                        };

            return query.ToList();
        }

        public async Task<IEnumerable<BookInvoice>> SearchBookInvoiceById(string id)
        {
            return await _dbSet.Where(bi => bi.id.Contains(id)).ToListAsync();
        }
    }
}
