using Microsoft.AspNetCore.Mvc;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.DTO;
using WebAPI_BookStoreManagement.Services;

namespace WebAPI_BookStoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : Controller
    {
        private readonly IAuthorService _authorService;

        public AuthorController(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAuthorAsync()
        {
            var authors = await _authorService.GetAllAuthorAsync();
            return Ok(authors);
        }

        [HttpGet("{name}")]
        public async Task<IActionResult> GetAuthorByNameAsync(string name)
        {
            var author = await _authorService.SearchAuthorByName(name);
            if (author == null)
                return NotFound();

            return Ok(author);
        }

        [HttpPost]
        public async Task<IActionResult> AddAuthorAsync([FromBody] AuthorDTO authorDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var author = new Author
            {
                fullname = authorDTO.fullname,
                addre = authorDTO.addre
            };

            await _authorService.AddAuthorAsync(author);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAuthorAsync(int id, AuthorDTO authorDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingAuthor = await _authorService.GetAuthorByIdAsync(id);
            if (existingAuthor == null)
                return NotFound($"Author with ID {id} not found.");

            existingAuthor.fullname = authorDTO.fullname ?? existingAuthor.fullname;
            existingAuthor.addre = authorDTO.addre ?? existingAuthor.addre;


            await _authorService.UpdateAuthorAsync(existingAuthor);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAuthorAsync(int id)
        {
            var existingAuthor = await _authorService.GetAuthorByIdAsync(id);
            if (existingAuthor == null)
                return NotFound($"Author with ID {id} not found.");

            await _authorService.DeleteAuthorAsync(id);
            return NoContent();
        }
    }
}
