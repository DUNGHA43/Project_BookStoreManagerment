using Microsoft.AspNetCore.Mvc;
using WebAPI_BookManagement.Model;
using WebAPI_BookStoreManagement.DTO;
using WebAPI_BookStoreManagement.Services;

namespace WebAPI_BookStoreManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : Controller
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAccount()
        {
            var accounts = await _accountService.GetAllAcountAsync();
            return Ok(accounts);
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> GetAccountByUsernameAsync(string username)
        {
            var account = await _accountService.GetAccountByUsernameAsync(username);

            if(account == null)
            {
                return NotFound();
            }
            return Ok(account);
        }

        [HttpGet("{username}, {password}")]
        public async Task<IActionResult> LoginAccountAsync(string username, string password)
        {
            var logindetail = await _accountService.LoginAsync(username, password);
            if (logindetail != null)
                return Ok(logindetail);

            return Unauthorized("Wrong username or password!");
        }

        [HttpPost]
        public async Task<IActionResult> AddAccountAsync([FromBody] AccountDTO accountDTO)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var account = new Account
            {
                username = accountDTO.username,
                passw = accountDTO.passw,
                roleacc = accountDTO.roleacc,
                idstaff = accountDTO.idstaff
            };

            await _accountService.AddAccountAsync(account);
            return NoContent();
        }

        [HttpPut("{username}")]
        public async Task<IActionResult> UpdateAccountAsync(string username, [FromBody] AccountDTO accountDTO)
        {
            if(!ModelState.IsValid)
                return BadRequest(ModelState);

            var existingAccount = await _accountService.GetAccountByUsernameAsync(username);
            if(existingAccount == null)
                return NotFound($"Account with Username {username} not found!");

            existingAccount.username = accountDTO.username ?? existingAccount.username;
            existingAccount.passw = accountDTO.passw ?? existingAccount.passw;
            existingAccount.roleacc = accountDTO.roleacc ?? existingAccount.roleacc;
            existingAccount.idstaff = accountDTO.idstaff ?? existingAccount.idstaff;

            await _accountService.UpdateAccountAsync(existingAccount);
            return NoContent();
        }

        [HttpDelete("{username}")]
        public async Task<IActionResult> DeleteAccountAsync(string username)
        {
            var existingAccount = await _accountService.GetAccountByUsernameAsync(username);
            if (existingAccount == null)
                return NotFound($"Account with Username {username} not found!");

            await _accountService.DeleteAccountAsync(username);
            return NoContent();
        }
    }
}
