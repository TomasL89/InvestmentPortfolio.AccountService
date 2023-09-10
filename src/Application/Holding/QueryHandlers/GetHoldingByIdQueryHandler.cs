using Application.Abstractions;
using Application.Holding.Queries;
using MediatR;

namespace Application.Holding.QueryHandlers;

public class GetHoldingByIdQueryHandler : IRequestHandler<GetHoldingById, Domain.Entities.Holding?>
{
    private readonly IHoldingRepository _holdingRepository;

    public GetHoldingByIdQueryHandler(IHoldingRepository holdingRepository)
    {
        _holdingRepository = holdingRepository;
    }

    public async Task<Domain.Entities.Holding?> Handle(GetHoldingById request, CancellationToken cancellationToken)
    {
        return await _holdingRepository.GetHoldingByIdAsync(request.Id);
    }
}