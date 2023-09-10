using Domain.Entities;

namespace Application.Abstractions;

public interface IHoldingRepository
{
    Task<Domain.Entities.Holding> CreateHoldingAsync(Domain.Entities.Holding holding);
    Task<Domain.Entities.Holding?> GetHoldingByIdAsync(Guid id);
    Task<List<Domain.Entities.Holding>> GetAllHoldingsByAccountIdAsync(Guid accountId);
    Task<List<Domain.Entities.Holding>> GetAllHoldingsAsync();
    Task DeleteHoldingAsync(Guid id);
}