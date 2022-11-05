using HealthyPets.API.Profiles.Domain.Model;

namespace HealthyPets.API.Profiles.Domain.Services;

public interface IPersonsService
{
    Task<IEnumerable<Client>> ListAsync();
}