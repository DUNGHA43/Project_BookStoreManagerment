using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.DTO;
using WebAPI_BookStoreManagement.Services;

namespace WebAPI_BookStoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StaffController : Controller
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllStaff()
        {
            var staff = await _staffService.GetAllStaffAsync();
            return Ok(staff);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaffById(string id)
        {
            var staff = await _staffService.GetStaffByIdAsync(id);
            if (staff == null)
            {
                return NotFound();
            }
            return Ok(staff);
        }

        [HttpPost]
        public async Task<IActionResult> AddStaff([FromBody] StaffDTO staffDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staff = new Staff
            {
                id = staffDTO.id,
                fullname = staffDTO.fullname,
                birthday = staffDTO.birthday,
                identification = staffDTO.identification,
                phonenumber = staffDTO.phonenumber,
                addre = staffDTO.addre,
                workschedule = staffDTO.workschedule
            };

            await _staffService.AddStaffAsync(staff);

            return CreatedAtAction(nameof(GetStaffById), new { id = staff.id }, staff);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateStaff(string id, [FromBody] StaffDTO staffDTO)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingStaff = await _staffService.GetStaffByIdAsync(id);
            if (existingStaff == null)
                return NotFound($"Staff with ID {id} not found.");

            existingStaff.fullname = staffDTO.fullname ?? existingStaff.fullname;
            existingStaff.birthday = staffDTO.birthday ?? existingStaff.birthday;
            existingStaff.identification = staffDTO.identification ?? existingStaff.identification;
            existingStaff.phonenumber = staffDTO.phonenumber ?? existingStaff.phonenumber;
            existingStaff.addre = staffDTO.addre ?? existingStaff.addre;
            existingStaff.workschedule = staffDTO.workschedule ?? existingStaff.workschedule;

            await _staffService.UpdateStaffAsync(existingStaff);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff(string id)
        {
            var existingStaff = await _staffService.GetStaffByIdAsync(id);
            if (existingStaff == null)
                return NotFound($"Staff with ID {id} not found.");

            await _staffService.DeleteStaffAsync(existingStaff.id);
            return NoContent();
        }
    }
}
