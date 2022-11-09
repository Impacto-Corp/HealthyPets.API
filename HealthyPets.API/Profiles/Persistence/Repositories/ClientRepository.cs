using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Repositories;
using HealthyPets.API.Shared.Persistence.Contexts;
using HealthyPets.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HealthyPets.API.Profiles.Persistence.Repositories;

public class ClientRepository:BaseRepository, IClientRepository
{
    public ClientRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Client>> ListAsync()
    {
        return await _context.Clients.ToListAsync();
    }

    public async Task AddAsync(Client client)
    {
     await _context.Clients.AddAsync(client);
    }
    public async Task<Mechanic> FindByIdAsync(long id)
    {
        return await _context.Mechanics.FindAsync(id);
    }

    public async Task<Client> FindByIdAsync(int id)
    {
        return await _context.Clients.FindAsync(id);
    }
    public void Update(Client client)
    {
        _context.Clients.Update(client);
    }

    public void Remove(Client client)
    {
        _context.Clients.Remove(client);

    }
}