using Application.Abstractions;
using Domain.Entities;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Repositories;

public class AccountRepository : IAccountRepository
{
    private readonly AccountDbContext _context;

    public AccountRepository(AccountDbContext context)
    {
        _context = context;
    }

    public async Task<Account> CreateAccountAsync(Account account)
    {
        await _context.Accounts.AddAsync(account);
        await _context.SaveChangesAsync();

        return account;
    }

    public async Task<Account> UpdateAccountAsync(Guid id, string? firstName, string? lastName, double accountBalance, double feesPaid, double taxesPaid, bool? isBot, TradingMethod? tradingMethod)
    {
        var account = await _context.Accounts.FirstOrDefaultAsync(a => a.Id == id);
        
        if (account == null)
        {
            throw new Exception("Account not found");
        }
        
        account.FirstName = firstName ?? account.FirstName;
        account.LastName = lastName ?? account.LastName;
        account.AccountBalance = accountBalance;
        account.FeesPaid = feesPaid;
        account.TaxesPaid = taxesPaid;
        account.IsBot = isBot ?? account.IsBot;
        account.TradingMethod = tradingMethod ?? account.TradingMethod;
        
        await _context.SaveChangesAsync();

        return account;
    }
    
    public async Task<Account?> GetAccountByIdAsync(Guid id)
    {
        return await _context.Accounts.FirstOrDefaultAsync(a => a.Id == id);
    }

    public async Task DeleteAccountAsync(Guid id)
    {
        var account = await _context.Accounts.FirstOrDefaultAsync(a => a.Id == id);
        
        if (account == null)
        {
            throw new Exception("Account not found");
        }
        
        _context.Accounts.Remove(account);

        await _context.SaveChangesAsync();
    }
}