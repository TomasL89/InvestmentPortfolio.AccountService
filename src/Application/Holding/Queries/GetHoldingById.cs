using MediatR;

namespace Application.Holding.Queries;

public record GetHoldingById(Guid Id) : IRequest<Domain.Entities.Holding>;