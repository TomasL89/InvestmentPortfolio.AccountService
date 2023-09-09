using Domain.Entities;
using MediatR;

namespace Application.Commands;

public record UpdateAccount(
    Guid Id,
    string? FirstName,
    string? LastName,
    double AccountBalance,
    double FeesPaid,
    double TaxesPaid,
    bool? IsBot,
    TradingMethod? TradingMethod) : IRequest<Account>;
