using HealthyPets.API.Shared.Domein.Repositories;
using HealthyPets.API.Shared.Persistence.Contexts;

namespace HealthyPets.API.Shared.Persistence.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly AppDbContext _context;

    public UnitOfWork(AppDbContext context)
    {
        _context = context;
    }

    public async Task CompleteAsync()
    {
        await _context.SaveChangesAsync();
    }
    
}

    