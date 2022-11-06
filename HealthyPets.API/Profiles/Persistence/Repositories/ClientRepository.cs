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

    public Task<IEnumerable<Client>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Client client)
    {
        throw new NotImplementedException();
    }

    public Task<Client> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Client client)
    {
        throw new NotImplementedException();
    }

    public void Remove(Client client)
    {
        throw new NotImplementedException();
    }
}