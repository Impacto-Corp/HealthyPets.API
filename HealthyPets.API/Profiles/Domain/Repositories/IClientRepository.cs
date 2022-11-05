using HealthyPets.API.Profiles.Domain.Model;

namespace HealthyPets.API.Profiles.Domain.Repositories;

public interface IClientRepository
{
    Task<IEnumerable<Client>> ListAsync();
    Task AddAsync(Client client);
    Task<Client> FindByIdAsync(int id);
    void Update(Client client);
    void Remove(Client client);
}