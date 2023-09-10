using Application.Abstractions;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Application.Holding.Repositories;

public class HoldingRepository : IHoldingRepository
{
    private readonly AccountDbContext _dbContext;

    public HoldingRepository(AccountDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<Domain.Entities.Holding> CreateHoldingAsync(Domain.Entities.Holding holding)
    {
        await _dbContext.Holdings.AddAsync(holding);
        await _dbContext.SaveChangesAsync();
        
        return holding;
    }

    public async Task<Domain.Entities.Holding?> GetHoldingByIdAsync(Guid id)
    {
        return await _dbContext.Holdings.FirstOrDefaultAsync(h => h.Id == id);
    }

    public async Task<List<Domain.Entities.Holding>> GetAllHoldingsByAccountIdAsync(Guid accountId)
    {
        return await _dbContext.Holdings.Where(h => h.AccountId == accountId).ToListAsync();
    }

    public async Task<List<Domain.Entities.Holding>> GetAllHoldingsAsync()
    {
        return await _dbContext.Holdings.ToListAsync();
    }

    public async Task DeleteHoldingAsync(Guid id)
    {
        var holding = await _dbContext.Holdings.FirstOrDefaultAsync(h => h.Id == id);
        
        if (holding == null)
        {
            throw new Exception("Holding not found");
        }
        
        _dbContext.Holdings.Remove(holding);
        
        await _dbContext.SaveChangesAsync();
    }
}