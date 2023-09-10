using Application.Account.Commands;
using Application.Account.Queries;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("{accountId}")]
        public async Task<Account> GetAccount(Guid accountId)
        {
           return await _mediator.Send(new GetAccountById(accountId));
        }
        
        [HttpGet]
        public async Task<List<Account>> GetAllAccounts()
        {
            return await _mediator.Send(new GetAllAccounts());
        }

        [HttpPost]
        public async Task<Account> CreateNewAccount(string firstName, string lastName, bool isBot, TradingMethod tradingMethod)
        {
            return await _mediator.Send(new CreateAccount(firstName, lastName, isBot, tradingMethod));
        }

        [HttpPut("{accountId}")]
        public async Task<Account> UpdateAccount(Guid accountId, string firstName, string lastName, bool isBot, TradingMethod tradingMethod)
        {
            return await _mediator.Send(new UpdateAccount(accountId, firstName, lastName, isBot, tradingMethod));
        }

        [HttpDelete("{accountId}")]
        public async Task DeleteAccount(Guid accountId)
        {
            await _mediator.Send(new DeleteAccount(accountId));
        }
    }
}
