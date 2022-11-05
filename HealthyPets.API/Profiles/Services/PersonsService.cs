using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Repositories;
using HealthyPets.API.Profiles.Domain.Services;

namespace HealthyPets.API.Profiles.Services;

public class PersonsService : IPersonsService
{
    private readonly IPersonsRepository _personsRepository;
    
    public async Task<IEnumerable<Person>> ListAsync()
    {
        return await _personsRepository.ListAsync();
    }
}