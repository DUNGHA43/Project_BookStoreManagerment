using System.ComponentModel.DataAnnotations;

namespace WebAPI_BookStoreManagement.DTO
{
    public class BookReceiptDTO
    {
        public string? id { get; set; }
        public DateTime? dateentry { get; set; }
        public int? idpublisher { get; set; }
        public string? idstaff { get; set; }
        public decimal? totalprice { get; set; }
    }
}
