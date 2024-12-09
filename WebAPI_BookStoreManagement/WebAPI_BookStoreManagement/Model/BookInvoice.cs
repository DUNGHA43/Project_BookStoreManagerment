using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_BookManagement.Model
{
    [Table("TblBookInvoice")]
    public class BookInvoice
    {
        [Key]
        public string? id { get; set; }
        [Required]
        public DateTime? saledate { get; set; }
        public string? idstaff { get; set; }
        public decimal? totalprice { get; set; }

        public virtual Staff? staff { get; set; }
        public virtual ICollection<BookInvoiceDetail>? bookinvoicedetails {  get; set; }
    }
}
