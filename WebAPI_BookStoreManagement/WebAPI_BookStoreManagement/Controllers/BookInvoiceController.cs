using Microsoft.AspNetCore.Mvc;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.DTO;
using WebAPI_BookStoreManagement.Services;

namespace WebAPI_BookStoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookInvoiceController : Controller
    {
        private readonly IBookInvoiceService _bookinvoiceservice;

        public BookInvoiceController(IBookInvoiceService bookinvoiceservice)
        {
            _bookinvoiceservice = bookinvoiceservice;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookInvoiceAsync()
        {
            var bookinvoices = await _bookinvoiceservice.GetAllBookInvoiceAsync();

            return Ok(bookinvoices);
        }

        [HttpGet("id")]
        public async Task<IActionResult> GetBookInvoiceByIdAsync(string id)
        {
            var bookinvoice = await _bookinvoiceservice.SearchBookInvoiceByIdAsync(id);
            return Ok(bookinvoice);
        }

        [HttpGet("total/{id}")]
        public async Task<decimal?> GetTotalBookInvoiceAsync(string id)
        {
            var total = await _bookinvoiceservice.CalculateInvoiceTotalAsync(id);

            return total;
        }

        [HttpPost]
        public async Task<IActionResult> AddBookInvoiceAsync([FromBody] BookInvoiceDTO bookInvoiceDTO)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var bookinvoice = new BookInvoice {
                id = bookInvoiceDTO.id,
                saledate = bookInvoiceDTO.saledate,
                idstaff = bookInvoiceDTO.idstaff,
                totalprice = 0,
            };

            await _bookinvoiceservice.AddBookInvoiceAsync(bookinvoice);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBookInvoiceAsync(string id, [FromBody] BookInvoiceDTO bookInvoiceDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingbookinvoice = await _bookinvoiceservice.GetBookInvoiceById(id);
            if (existingbookinvoice == null)
                return NotFound($"Book invoice with ID: {id} not found!");

            existingbookinvoice.saledate = bookInvoiceDTO.saledate ?? existingbookinvoice.saledate;
            existingbookinvoice.idstaff = bookInvoiceDTO.idstaff ?? existingbookinvoice.idstaff;
            existingbookinvoice.totalprice = bookInvoiceDTO.totalprice ?? existingbookinvoice.totalprice;

            await _bookinvoiceservice.UpdateBookInvoiceAsync(existingbookinvoice);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookInvoiceAsync(string id)
        {
            var existingbookinvoice = await _bookinvoiceservice.GetBookInvoiceById(id);
            if (existingbookinvoice == null)
                return NotFound($"Book invoice with ID: {id} not found!");

            await _bookinvoiceservice.DeleteBookInvoiceAsync(id);
            return NoContent();
        }
    }
}
