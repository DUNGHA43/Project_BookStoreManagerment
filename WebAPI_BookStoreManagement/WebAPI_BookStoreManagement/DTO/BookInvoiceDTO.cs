using System.ComponentModel.DataAnnotations;

namespace WebAPI_BookStoreManagement.DTO
{
    public class BookInvoiceDTO
    {
        public string? id { get; set; }
        public DateTime? saledate { get; set; }
        public string? idstaff { get; set; }
        public decimal? totalprice { get; set; }
    }
}
