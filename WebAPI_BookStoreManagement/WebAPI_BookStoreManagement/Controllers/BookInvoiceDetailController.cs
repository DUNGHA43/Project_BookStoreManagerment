using Microsoft.AspNetCore.Mvc;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.DTO;
using WebAPI_BookStoreManagement.Services;

namespace WebAPI_BookStoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookInvoiceDetailController : Controller
    {
        private readonly IBookInvoiceDetailService _bookinvoicedetail;

        public BookInvoiceDetailController(IBookInvoiceDetailService bookinvoicedetail)
        {
            _bookinvoicedetail = bookinvoicedetail;
        }

        [HttpGet("{idinvoice}")]
        public async Task<IActionResult> GetAllBookInvoiceDetailForIdInvoiceAsync(string idinvoice)
        {
            var bookinvoicedetails = await _bookinvoicedetail.GetAllBookInvoiceDetailAsync(idinvoice);
            
            return Ok(bookinvoicedetails);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdateBookInvoiceDetailAsync([FromBody] BookInvoiceDetailDTO bookInvoiceDetailDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var bookinvoicedetail = new BookInvoiceDetail
            {
                idinvoice = bookInvoiceDetailDTO.idinvoice,
                idbook = bookInvoiceDetailDTO.idbook,
                quanlity = bookInvoiceDetailDTO.quanlity,
                totalprice = (decimal)await _bookinvoicedetail.CalculateTotalAsync(bookInvoiceDetailDTO.idbook, bookInvoiceDetailDTO.quanlity)
            };

            await _bookinvoicedetail.AddBookInvoiceDetailAsync(bookinvoicedetail);
            return NoContent();
        }

        [HttpDelete("{idinvoice},{idbook}")]
        public async Task<IActionResult> DeleteBookInvoiceDetailAsync(string idinvoice, string idbook)
        {
            var existingbookinvoicedetail = await _bookinvoicedetail.GetBookInvoiceDetailByIdAsync(idinvoice, idbook);
            if (existingbookinvoicedetail == null)
                return NotFound($"Book invoice detail with IDInvoice: {idinvoice} and IDBook: {idbook} not found!");

            await _bookinvoicedetail.DeleteBookInvoiceDetailAsync(idinvoice, idbook);
            return NoContent();
        }
    }
}
