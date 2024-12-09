﻿using Microsoft.AspNetCore.Mvc;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.DTO;
using WebAPI_BookStoreManagement.Services;

namespace WebAPI_BookStoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookReceiptController : Controller
    {
        private readonly IBookReceiptServices _bookReceiptServices;

        public BookReceiptController(IBookReceiptServices bookReceiptServices)
        {
            _bookReceiptServices = bookReceiptServices;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllBookReceiptAsync()
        {
            var bookreceipts = await _bookReceiptServices.GetAllBookReceiptAsync();

            return Ok(bookreceipts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBookReceiptByIdAsync(string id)
        {
            var bookreceipt = await _bookReceiptServices.GetBookReceiptById(id);

            if (bookreceipt == null)
                return NotFound();

            return Ok(bookreceipt);
        }

        [HttpPost]
        public async Task<IActionResult> AddBookReceiptAsync([FromBody] BookReceiptDTO bookReceiptDTO)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var bookrecipt = new BookReceipt
            {
                id = bookReceiptDTO.id,
                dateentry = bookReceiptDTO.dateentry,
                idpublisher = bookReceiptDTO.idpublisher,
                idstaff = bookReceiptDTO.idstaff,
                totalprice = 0
            };

            await _bookReceiptServices.AddBookReceiptAsync(bookrecipt);
            return NoContent();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateBookReceiptAsync(string id, [FromBody] BookReceiptDTO bookReceiptDTO)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingbookreceipt = await _bookReceiptServices.GetBookReceiptById(id);
            if (existingbookreceipt == null)
                return NotFound($"Book receipt with ID: {id} not found!");

            existingbookreceipt.dateentry = bookReceiptDTO.dateentry ?? existingbookreceipt.dateentry;
            existingbookreceipt.idstaff = bookReceiptDTO.idstaff ?? existingbookreceipt.idstaff;

            await _bookReceiptServices.UpdateBookReceiptAsync(existingbookreceipt);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBookReceiptAsync(string id)
        {
            var existingbookreceipt = await _bookReceiptServices.GetBookReceiptById(id);
            if (existingbookreceipt == null)
                return NotFound($"Book receipt with ID: {id} not found!");

            await _bookReceiptServices.DeleteBookReceiptAsync(id);
            return NoContent();
        }
    }
}
