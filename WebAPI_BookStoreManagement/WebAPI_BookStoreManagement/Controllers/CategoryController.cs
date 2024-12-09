using Microsoft.AspNetCore.Mvc;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.DTO;
using WebAPI_BookStoreManagement.Services;

namespace WebAPI_BookStoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllCategoryAsync()
        {
            var categories = await _categoryService.GetAllCategoryAsync();
            return Ok(categories);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryByIdAsync(int id)
        {
            var author = await _categoryService.GetCategoryByIdAsync(id);
            if (author == null)
                return NotFound();

            return Ok(author);
        }

        [HttpPost]
        public async Task<IActionResult> AddCategoryAsync([FromBody] CateggoryDTO categgoryDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var category = new Category
            {
                namecategory = categgoryDTO.namecategory,
            };

            await _categoryService.AddCategoryAsync(category);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategoryAsync(int id, CateggoryDTO categgoryDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingCate = await _categoryService.GetCategoryByIdAsync(id);
            if (existingCate == null)
                return NotFound($"Category with ID {id} not found.");

            existingCate.namecategory = categgoryDTO.namecategory ?? existingCate.namecategory;


            await _categoryService.UpdateCategoryAsync(existingCate);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryAsync(int id)
        {
            var existingCate = await _categoryService.GetCategoryByIdAsync(id);
            if (existingCate == null)
                return NotFound($"Author with ID {id} not found.");

            await _categoryService.DeleteCategoryAsync(id);
            return NoContent();
        }
    }
}
