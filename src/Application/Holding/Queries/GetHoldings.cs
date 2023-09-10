using MediatR;

namespace Application.Holding.Queries;

public record GetHoldings() : IRequest<List<Domain.Entities.Holding>>;
