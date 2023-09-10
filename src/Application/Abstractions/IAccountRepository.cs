using Domain.Entities;

namespace Application.Abstractions;

public interface IAccountRepository
{
    Task<Domain.Entities.Account> CreateAccountAsync(Domain.Entities.Account account);
    Task<Domain.Entities.Account> UpdateAccountAsync(Guid id, string? firstName, string? lastName, bool? isBot, TradingMethod? tradingMethod);
    Task<Domain.Entities.Account?> GetAccountByIdAsync(Guid id);
    Task<List<Domain.Entities.Account>> GetAllAccountsAsync();    
    Task DeleteAccountAsync(Guid id);
}