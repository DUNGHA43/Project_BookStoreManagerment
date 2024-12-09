using System.ComponentModel.DataAnnotations;

namespace WebAPI_BookStoreManagement.DTO
{
    public class BookReceiptDetailDTO
    {
        public string? idreceipt { get; set; }
        public string? idbook { get; set; }
        public int? quanlity { get; set; }
        public decimal? totalprice { get; set; }
    }
}
