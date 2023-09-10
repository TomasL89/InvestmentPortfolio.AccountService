using Application.Abstractions;
using Application.Holding.Queries;
using MediatR;

namespace Application.Holding.QueryHandlers;

public class GetAllHoldingsForAccountQueryHandler : IRequestHandler<GetAllHoldingsForAccount, List<Domain.Entities.Holding>>
{
    private readonly IHoldingRepository _holdingRepository;

    public GetAllHoldingsForAccountQueryHandler(IHoldingRepository holdingRepository)
    {
        _holdingRepository = holdingRepository;
    }

    public async Task<List<Domain.Entities.Holding>> Handle(GetAllHoldingsForAccount request, CancellationToken cancellationToken)
    {
        return await _holdingRepository.GetAllHoldingsByAccountIdAsync(request.AccountId);
    }
}