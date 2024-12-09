using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_BookManagement.Model
{
    [Table("TblAuthor")]
    public class Author
    {
        [Key]
        public int? id { get; set; }
        [Required]
        public string? fullname { get; set; }
        public string? addre {  get; set; }

        public virtual ICollection<Book>? books { get; set; }
    }
}
