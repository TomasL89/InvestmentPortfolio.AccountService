using Domain.Entities;
using MediatR;

namespace Application.Account.Commands;

public record CreateAccount(
    string? FirstName,
    string? LastName,
    bool IsBot,
    TradingMethod TradingMethod) : IRequest<Domain.Entities.Account>;
