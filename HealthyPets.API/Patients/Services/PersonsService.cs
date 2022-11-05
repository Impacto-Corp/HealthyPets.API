using HealthyPets.API.Patients.Domain;
using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Patients.Domain.Repositories;
using HealthyPets.API.Patients.Domain.Services;

namespace HealthyPets.API.Patients.Services;

public class PersonsService : IPersonsService
{
    private readonly IPersonsRepository _personsRepository;
    
    public async Task<IEnumerable<Person>> ListAsync()
    {
        return await _personsRepository.ListAsync();
    }
}