using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebAPI_BookManagement.Model
{
    [Table("TblAccount")]
    public class Account
    {
        [Key]
        public string? username { get; set; }
        [Required]
        public string? passw { get; set; }
        public string? roleacc { get; set; }
        public string? idstaff { get; set; }

        public virtual Staff staff { get; set; }
    }
}
