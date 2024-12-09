using System.ComponentModel.DataAnnotations;

namespace WebAPI_BookStoreManagement.DTO
{
    public class BookInvoiceDetailDTO
    {
        public string? idinvoice { get; set; }
        public string? idbook { get; set; }
        public int? quanlity { get; set; }
        public decimal? totalprice { get; set; }
    }
}
