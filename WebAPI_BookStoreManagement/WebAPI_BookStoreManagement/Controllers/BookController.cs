using Microsoft.AspNetCore.Mvc;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.DTO;
using WebAPI_BookStoreManagement.Services;

namespace WebAPI_BookStoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : Controller
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookAsync()
        {
            var books = await _bookService.GetAllBookAsync();
            return Ok(books);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookByIdAsync(string id)
        {
            var book = await _bookService.GetBookByIdAsync(id);
            if(book == null)
                return NotFound();

            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddBookAsync([FromBody] BookDTO bookDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var book = new Book
            {
                id = bookDTO.id,
                namebook = bookDTO.namebook,
                quanlitystock = bookDTO.quanlitystock,
                importprice = bookDTO.importprice,
                retailprice = bookDTO.retailprice,
                idcate = bookDTO.idcate,
                idau = bookDTO.idau,
                idpub = bookDTO.idpub,
            };

            await _bookService.AddBookAsync(book);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBookAsync(string id, [FromBody] BookDTO bookDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingBook = await _bookService.GetBookByIdAsync(id);
            if (existingBook == null)
                return NotFound($"Book with ID {id} not found.");

            existingBook.id = bookDTO.id ?? existingBook.id;
            existingBook.namebook = bookDTO.namebook ?? existingBook.namebook;
            existingBook.quanlitystock = bookDTO.quanlitystock ?? existingBook.quanlitystock;
            existingBook.importprice = bookDTO.importprice ?? existingBook.importprice;
            existingBook.retailprice = bookDTO.retailprice ?? existingBook.retailprice;
            existingBook.idcate = bookDTO.idcate ?? existingBook.idcate;
            existingBook.idau = bookDTO.idau ?? existingBook.idau;
            existingBook.idpub = bookDTO.idpub ?? existingBook.idpub;

            await _bookService.UpdateBookAsync(existingBook);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookAsync(string id)
        {
            var existingBook = await _bookService.GetBookByIdAsync(id);
            if (existingBook == null)
                return NotFound($"Book with ID {id} not found.");

            await _bookService.DeleteBookAsync(id);
            return NoContent();
        }
    }
}
