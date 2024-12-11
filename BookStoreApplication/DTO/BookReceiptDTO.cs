using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookReceiptDTO
    {
        public string? id { get; set; }
        public DateTime? dateentry { get; set; }
        public int? idpublisher { get; set; }
        public string? idstaff { get; set; }
        public decimal? totalprice { get; set; }
    }
}
