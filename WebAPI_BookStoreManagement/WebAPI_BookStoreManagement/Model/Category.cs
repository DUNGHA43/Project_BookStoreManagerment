using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_BookManagement.Model
{
    [Table("TblCategory")]
    public class Category
    {
        [Key]
        public int? id { get; set; }
        [Required]
        public string? namecategory { get; set; }

        public virtual ICollection<Book>? books { get; set; }
    }
}
