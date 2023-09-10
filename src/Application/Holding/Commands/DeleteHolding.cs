using MediatR;

namespace Application.Holding.Commands;

public record DeleteHolding(Guid Id) : IRequest {}