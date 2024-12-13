using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookDTO
    {
        public string? id { get; set; }
        public string? namebook { get; set; }
        public int? quanlitystock { get; set; }
        public float? importprice { get; set; }
        public float? retailprice { get; set; }
        public int? idcate { get; set; }
        public int? idau { get; set; }
        public int? idpub { get; set; }
    }
}
