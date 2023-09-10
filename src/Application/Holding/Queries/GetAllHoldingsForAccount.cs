using MediatR;

namespace Application.Holding.Queries;

public record GetAllHoldingsForAccount(Guid AccountId) : IRequest<List<Domain.Entities.Holding>>;
