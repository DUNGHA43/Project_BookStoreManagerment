using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_BookManagement.Model
{
    [Table("TblStaff")]
    public class Staff
    {
        [Key]
        public string? id { get; set; }
        [Required]
        public string? fullname { get; set; }
        public DateTime? birthday { get; set; }
        public string? identification { get; set; }
        public string? phonenumber { get; set; }
        public string? addre {  get; set; }
        public string? workschedule { get; set; }

        public virtual Account? account { get; set; }
        public virtual ICollection<BookReceipt>? bookreceipts { get; set; }
        public virtual ICollection<BookInvoice>? bookinvoices { get; set; }
    }
}
