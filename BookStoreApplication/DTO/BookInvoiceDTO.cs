using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookInvoiceDTO
    {
        public string? id { get; set; }
        public DateTime? saledate { get; set; }
        public string? idstaff { get; set; }
        public decimal? totalprice { get; set; }
    }
}
