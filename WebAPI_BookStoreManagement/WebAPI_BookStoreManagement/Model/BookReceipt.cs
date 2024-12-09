using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_BookManagement.Model
{
    [Table("TblBookReceipts")]
    public class BookReceipt
    {
        [Key]
        public string? id { get; set; }
        [Required]
        public DateTime? dateentry { get; set; }
        public int? idpublisher { get; set; }
        public string? idstaff { get; set; }
        public decimal? totalprice { get; set; }

        public virtual Publisher? publisher { get; set; }
        public virtual Staff? staff { get; set; }
        public virtual ICollection<BookReceiptDetail>? bookreceiptsdetalls { get; set; }
    }
}
