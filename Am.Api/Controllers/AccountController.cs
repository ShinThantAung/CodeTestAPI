using Am.Infrastructure.Dto.Account;
using Am.Infrastructure.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Am.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class AccountController : ControllerBase
    {
        #region Private
        private readonly IAccountService _AccountService;
        private readonly ILogger<AccountController> _logger;
        #endregion

        // TODO: Add Centralize Logging
        public AccountController(IAccountService AccountService,
            ILogger<AccountController> logger)
        {
            _AccountService = AccountService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<List<AccountResponseViewModel>>> GetAccounts()
        {
            return await _AccountService.GetAllAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AccountResponseViewModel>> GetAccount(long id)
        {
            var viewModel = await _AccountService.GetAsync(id);
            if(viewModel == null)
                return NotFound();
            return viewModel;
        }

        [HttpPost]
        public async Task<ActionResult> AddAccount(AccountRequestViewModel viewModel)
        {
            await _AccountService.AddAsync(viewModel);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAccount(long id, AccountRequestViewModel viewModel)
        {
            if (id != viewModel.Id)
                return BadRequest();

            await _AccountService.UpdateAsync(viewModel);

            return NoContent();
        }


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(long id)
        {
            //throw new ArgumentNullException("Exception from API");
            await _AccountService.DeleteAsync(id);
            return NoContent();
        }
    }
}