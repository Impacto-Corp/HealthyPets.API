using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Repositories;
using HealthyPets.API.Shared.Persistence.Contexts;
using HealthyPets.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HealthyPets.API.Profiles.Persistence.Repositories;

public class VeterinaryRepository : BaseRepository, IVeterinaryRepository
{
    public VeterinaryRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Veterinary>> ListAsync()
    {
        return await _context.Veterinaries.ToListAsync();
    }

    public async Task AddAsync(Veterinary veterinary)
    {
        await _context.Veterinaries.AddAsync(veterinary);    
    }

    public async Task<Veterinary> FindByIdAsync(int id)
    {
        return await _context.Veterinaries.FindAsync(id);
    }

    public void Update(Veterinary veterinary)
    {
        _context.Veterinaries.Update(veterinary);
    }

    public void Remove(Veterinary veterinary)
    {
        _context.Veterinaries.Remove(veterinary);
    }
}