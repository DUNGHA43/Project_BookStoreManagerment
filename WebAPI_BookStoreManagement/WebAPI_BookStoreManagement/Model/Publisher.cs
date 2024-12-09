using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_BookManagement.Model
{
    [Table("TblPublishers")]
    public class Publisher
    {
        [Key]
        public int? id { get; set; }
        [Required]
        public string? namepublisher { get; set; }
        public string? phonenumber { get; set; }
        public string? addre {  get; set; }

        public virtual ICollection<Book>? books { get; set; }
        public virtual ICollection<BookReceipt>? bookreceipts { get; set; }
    }
}
