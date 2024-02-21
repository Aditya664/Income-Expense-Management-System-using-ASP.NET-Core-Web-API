using INCOMEEXPENSE.Web.DTO;
using INCOMEEXPENSE.Web.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace INCOMEEXPENSE.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;

        public AccountController(IRepositoryWrapper repository)
        {
            _repository = repository;
        }

        [HttpGet("GetAllAccount/{userId}")]
        public IActionResult Get(Guid userId)
        {
            var accounts = _repository.Account.FindByCondition(x => x.Id == userId).ToList();
            var accountResponseList = accounts.Select(x => new AccountResponseDto
            {
                Id = x.Id,
                AccountName = x.AccountName,
                AccountType = x.AccountType,
                InitialAmount = x.InitialAmount,
            });
            return Ok(accountResponseList);
        }
    }
}
