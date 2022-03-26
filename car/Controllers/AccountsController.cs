using car.ViewModels;
using Cars.BLL.Contracts;
using Cars.BLL.Dtos;
using Mapster;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using System.Collections.Generic;
using System.Net;

namespace car.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IAccountsServices _accountsServices;
        public AccountsController(IAccountsServices accountsService) => _accountsServices = accountsService;

        [HttpPost("")]
        [ProducesResponseType(typeof(AccountsViewModel), (int)HttpStatusCode.OK)]
        [SwaggerOperation(Summary = "Создание аккаунта")]
        public IActionResult CreateAccount(CreateAccountViewModel create)
        {
            var addAccount = create.Adapt<CreateAccountDto>();
            var account = _accountsServices.CreateAccount(addAccount);
            var result = account.Adapt<CreateAccountViewModel>();

            return Ok(result);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(AccountsViewModel), (int)HttpStatusCode.OK)]
        [SwaggerOperation(Summary = "Получение по ID")]
        public IActionResult GetIdAccount(long id)
        {
            var account = _accountsServices.GetIdAccount(id);
            var result = account.Adapt<AccountsViewModel>();

            return Ok(result);
        }

        [HttpPost("{login}")]
        [ProducesResponseType(typeof(AccountsViewModel), (int)HttpStatusCode.OK)]
        [SwaggerOperation(Summary = "Получение по Логину и Паролю")]
        public IActionResult GetLogPas(string login, string password)
        {
            var account = _accountsServices.GetLogPas(login, password);
            var result = account.Adapt<AccountsViewModel>();

            return Ok(result);
        }
    }
}
