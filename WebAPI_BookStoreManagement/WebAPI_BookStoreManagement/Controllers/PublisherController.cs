using Microsoft.AspNetCore.Mvc;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.DTO;
using WebAPI_BookStoreManagement.Services;

namespace WebAPI_BookStoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PublisherController : Controller
    {
        private readonly IPublisherService _publisherService;

        public PublisherController(IPublisherService publisherService)
        {
            _publisherService = publisherService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPublisherAsync()
        {
            var publishers = await _publisherService.GetAllPublisherAsync();
            return Ok(publishers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPublisherByIdAsync(int id)
        {
            var publisher = await _publisherService.GetPublisherByIdAsync(id);
            if (publisher == null)
                return NotFound();

            return Ok(publisher);
        }

        [HttpPost]
        public async Task<IActionResult> AddPublisherAsync([FromBody] PublisherDTO publisherDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var publisher = new Publisher
            {
                namepublisher = publisherDTO.namepublisher,
                phonenumber = publisherDTO.phonenumber,
                addre = publisherDTO.addre
            };

            await _publisherService.AddPublisherAsync(publisher);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdatePublisherAsync(int id, PublisherDTO publisherDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingPublisher = await _publisherService.GetPublisherByIdAsync(id);
            if (existingPublisher == null)
                return NotFound($"Publisher with ID {id} not found.");

            existingPublisher.namepublisher = publisherDTO.namepublisher ?? existingPublisher.namepublisher;
            existingPublisher.phonenumber = publisherDTO.phonenumber ?? existingPublisher.phonenumber;
            existingPublisher.addre = publisherDTO.addre ?? existingPublisher.addre;


            await _publisherService.UpdatePublisherAsync(existingPublisher);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePublisherAsync(int id)
        {
            var existingPublisher = await _publisherService.GetPublisherByIdAsync(id);
            if (existingPublisher == null)
                return NotFound($"Publisher with ID {id} not found.");

            await _publisherService.DeletePublisherAsync(id);
            return NoContent();
        }
    }
}
