using Application.Holding.Queries;
using Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoldingController : ControllerBase
    {
        private readonly IMediator _mediator;

        public HoldingController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("Account/{accountId}", Name = "GetHoldingsForAccount")]
        public async Task<List<Holding>> GetHoldingsForAccount(Guid accountId)
        {
            return await _mediator.Send(new GetAllHoldingsForAccount(accountId));
        }
        
        [HttpGet("{id}", Name = "GetHolding")]
        public async Task<Holding> GetHolding(Guid id)
        {
            return await _mediator.Send(new GetHoldingById(id));
        }
        
        [HttpGet(Name = "GetHoldings")]
        public async Task<List<Holding>> GetHoldings()
        {
            return await _mediator.Send(new GetHoldings());
        }
    }
}
