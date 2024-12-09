using Microsoft.AspNetCore.Mvc;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.DTO;
using WebAPI_BookStoreManagement.Services;

namespace WebAPI_BookStoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookReceiptDetailController : Controller
    {
        private readonly IBookReceiptDetailServices _bookreceiptdetail;

        public BookReceiptDetailController(IBookReceiptDetailServices bookreceiptdetail)
        {
            _bookreceiptdetail = bookreceiptdetail;
        }

        [HttpGet("{idreceipt}")]
        public async Task<IActionResult> GetAllBookReceiptDetailAsync(string idreceipt)
        {
            var bookreceiptdetails = await _bookreceiptdetail.GetAllBookReceiptDetailAsync(idreceipt);
            return Ok(bookreceiptdetails);
        }

        [HttpPost]
        public async Task<IActionResult> AddOrUpdateBookReceiptDetailAsync([FromBody] BookReceiptDetailDTO bookReceiptDetailDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var bookreciptdetail = new BookReceiptDetail
            {
                idreceipt = bookReceiptDetailDTO.idreceipt,
                idbook = bookReceiptDetailDTO.idbook,
                quanlity = bookReceiptDetailDTO.quanlity,
                totalprice = (decimal)await _bookreceiptdetail.CalculateTotalAsync(bookReceiptDetailDTO.idbook, bookReceiptDetailDTO.quanlity)
            };

            await _bookreceiptdetail.AddBookReceiptDetailAsync(bookreciptdetail);
            return NoContent();
        }

        [HttpDelete("{idreceipt}, {idbook}")]
        public async Task<IActionResult> DeleteBookReceiptDetailAsync(string idreceipt, string idbook)
        {
            var existingbookreceiptdetail = await _bookreceiptdetail.GetBookReceiptDetailByIdAsync(idreceipt, idbook);
            if (existingbookreceiptdetail == null)
                return NotFound($"Book Receipt Detail with IDReceipt: {idreceipt} and IDBook: {idbook} not found!");

            await _bookreceiptdetail.DeleteBookReceiptDetailAsync(idreceipt, idbook);
            return NoContent();
        }

    }
}
