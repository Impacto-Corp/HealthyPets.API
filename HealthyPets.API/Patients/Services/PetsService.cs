using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Patients.Domain.Repositories;
using HealthyPets.API.Patients.Domain.Services;

namespace HealthyPets.API.Patients.Services;

public class PetsService : IPetsService
{
    private readonly IPetsRepository _petsRepository;
    
    public async Task<IEnumerable<Pet>> ListAsync()
    {
        return await _petsRepository.ListAsync();
    }
}