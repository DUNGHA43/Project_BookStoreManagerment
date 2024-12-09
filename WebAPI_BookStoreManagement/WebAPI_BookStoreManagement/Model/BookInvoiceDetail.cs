using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_BookManagement.Model
{
    [Table("TblBookInvoiceDetail")]
    public class BookInvoiceDetail
    {
        [Key]
        public string? idinvoice {  get; set; }
        [Key]
        public string? idbook { get; set; }
        [Required]
        public int? quanlity { get; set; }
        public decimal? totalprice { get; set; }

        public virtual BookInvoice? bookinvoice { get; set; }
        public virtual Book? book { get; set; }
    }
}
