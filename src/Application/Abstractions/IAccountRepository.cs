using Domain.Entities;

namespace Application.Abstractions;

public interface IAccountRepository
{
    Task<Account> CreateAccountAsync(Account account);
    Task<Account> UpdateAccountAsync( Guid id, string? firstName, string? lastName, double accountBalance, double feesPaid, double taxesPaid, bool? isBot, TradingMethod? tradingMethod);
    Task<Account?> GetAccountByIdAsync(Guid id);
    Task DeleteAccountAsync(Guid id);
}