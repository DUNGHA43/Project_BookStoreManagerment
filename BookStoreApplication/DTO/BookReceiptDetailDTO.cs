using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookReceiptDetailDTO
    {
        public string? idreceipt { get; set; }
        public string? idbook { get; set; }
        public int? quanlity { get; set; }
        public decimal? totalprice { get; set; }
    }
}
