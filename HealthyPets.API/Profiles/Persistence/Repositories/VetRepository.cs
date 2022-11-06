using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Repositories;
using HealthyPets.API.Shared.Persistence.Contexts;
using HealthyPets.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HealthyPets.API.Profiles.Persistence.Repositories;

public class VetRepository : BaseRepository, IVetRepository
{
    public VetRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Vet>> ListAsync()
    {
        return await _context.Vets.ToListAsync();
    }

    public async Task AddAsync(Vet vet)
    {
        await _context.Vets.AddAsync(vet);
    }

    public async Task<Vet> FindByIdAsync(int id)
    {
        return await _context.Vets.FindAsync(id);
    }

    public void Update(Vet vet)
    {
        _context.Vets.Update(vet);
    }

    public void Remove(Vet vet)
    {
        _context.Vets.Remove(vet);
    }
}