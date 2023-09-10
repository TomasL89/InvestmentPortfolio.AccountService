using Application.Abstractions;
using Application.Holding.Queries;
using MediatR;

namespace Application.Holding.QueryHandlers;

public class GetAllHoldingsQueryHandler : IRequestHandler<GetHoldings, List<Domain.Entities.Holding>>
{
    private readonly IHoldingRepository _holdingRepository;

    public GetAllHoldingsQueryHandler(IHoldingRepository holdingRepository)
    {
        _holdingRepository = holdingRepository;
    }

    public async Task<List<Domain.Entities.Holding>> Handle(GetHoldings request, CancellationToken cancellationToken)
    {
        return await _holdingRepository.GetAllHoldingsAsync();
    }
}