using Application.Abstractions;
using Application.Holding.Commands;
using MediatR;

namespace Application.CommandHandlers;

public class DeleteHoldingCommandHandler : IRequestHandler<DeleteHolding>
{
    private readonly IHoldingRepository _holdingRepository;

    public DeleteHoldingCommandHandler(IHoldingRepository holdingRepository)
    {
        _holdingRepository = holdingRepository;
    }

    public async Task Handle(DeleteHolding request, CancellationToken cancellationToken)
    {
        await _holdingRepository.DeleteHoldingAsync(request.Id);
    }
}