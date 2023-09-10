using Application.Abstractions;
using Application.Account.Queries;
using Application.Holding.Commands;
using MediatR;

namespace Application.Holding.CommandHandlers;

public class CreateHoldingCommandHandler : IRequestHandler<CreateHolding, Domain.Entities.Holding>
{
    private readonly IHoldingRepository _holdingRepository;
    private readonly IMediator _mediator;

    public CreateHoldingCommandHandler(IHoldingRepository holdingRepository, IMediator mediator)
    {
        _holdingRepository = holdingRepository;
        _mediator = mediator;
    }

    public async Task<Domain.Entities.Holding> Handle(CreateHolding request, CancellationToken cancellationToken)
    {
        var account = await _mediator.Send(new GetAccountById(request.AccountId), cancellationToken);   
        
        if (account == null)
        {
            throw new Exception($"Account with id {request.AccountId} not found.");
        }
        
        var holding = new Domain.Entities.Holding
        {
            Account = account,
            Code = request.Code,
            Quantity = request.Quantity,
            Price = request.Price,
            DatePurchased = request.DatePurchased
        };
        
        return await _holdingRepository.CreateHoldingAsync(holding);
    }
}