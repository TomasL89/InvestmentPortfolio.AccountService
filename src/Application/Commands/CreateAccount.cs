using Domain.Entities;
using MediatR;

namespace Application.Commands;

public record CreateAccount(
    string? FirstName,
    string? LastName,
    bool IsBot,
    TradingMethod TradingMethod) : IRequest<Account>;
