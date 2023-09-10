using Domain.Entities;
using MediatR;

namespace Application.Account.Commands;

public record UpdateAccount(
    Guid Id,
    string? FirstName,
    string? LastName,
    bool? IsBot,
    TradingMethod? TradingMethod) : IRequest<Domain.Entities.Account>;
