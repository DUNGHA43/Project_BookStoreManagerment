using System.ComponentModel.DataAnnotations;

namespace WebAPI_BookStoreManagement.DTO
{
    public class AuthorDTO
    {
        public int? id { get; set; }
        public string? fullname { get; set; }
        public string? addre { get; set; }
    }
}
