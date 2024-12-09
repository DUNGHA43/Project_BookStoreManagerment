using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;

namespace WebAPI_BookManagement.Model
{
    [Table("TblBooks")]
    public class Book
    {
        [Key]
        public string? id { get; set; }
        [Required]
        public string? namebook { get; set; }
        public int? quanlitystock { get; set; }
        public float? importprice { get; set; }
        public float? retailprice { get; set; }
        public int? idcate { get; set; }
        public int? idau {  get; set; }
        public int? idpub { get; set; }

        public virtual Category? category { get; set; }
        public virtual Author? author { get; set; }
        public virtual Publisher? publisher { get; set; }
        public virtual BookInvoiceDetail? bookinvoicedetail { get; set; }
        public virtual BookReceiptDetail? bookreceiptdetail { get; set; }
    }
}
