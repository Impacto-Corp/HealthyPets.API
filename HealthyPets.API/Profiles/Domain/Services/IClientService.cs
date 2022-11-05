using HealthyPets.API.Profiles.Domain.Model;

namespace HealthyPets.API.Profiles.Domain.Services;

public interface IClientService
{
    Task<IEnumerable<Client>> ListAsync();
}