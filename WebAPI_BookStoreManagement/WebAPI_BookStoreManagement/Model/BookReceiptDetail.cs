using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_BookManagement.Model
{
    [Table("TblBookReceiptsDetail")]
    public class BookReceiptDetail
    {
        [Key]
        public string? idreceipt {  get; set; }
        [Key]
        public string? idbook { get; set; }
        [Required]
        public int? quanlity { get; set; }
        public decimal? totalprice { get; set; }

        public virtual BookReceipt? bookreceipt { get; set; }
        public virtual Book? book { get; set; }
    }
}
