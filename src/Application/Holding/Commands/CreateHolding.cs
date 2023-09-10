using MediatR;

namespace Application.Holding.Commands;

public record CreateHolding(
    Guid AccountId,
    string Code,
    string Name,
    DateTime DatePurchased,
    double Quantity,
    double Price,
    double StopLossPrice
) : IRequest<Domain.Entities.Holding> {}
