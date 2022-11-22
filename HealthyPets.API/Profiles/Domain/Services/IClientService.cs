using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Services.Communication;

namespace HealthyPets.API.Profiles.Domain.Services;

public interface IClientService
{
    Task<IEnumerable<Client>> ListAsync();
    Task<ClientResponse> SaveAsync(Client client);
    Task<ClientResponse> UpdateAsync(int id, Client client);
    Task<ClientResponse> DeleteAsync(int id);
}