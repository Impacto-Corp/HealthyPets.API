using HealthyPets.API.Profiles.Domain.Model;

namespace HealthyPets.API.Profiles.Domain.Repositories;

public class IVeterinaryRepository
{
    Task<IEnumerable<Veterinary>> ListAsync();
    Task AddAsync(Veterinary veterinary);
    Task<Veterinary> FindByIdAsync(int id);
    void Update(Veterinary veterinary);
    void Remove(Veterinary veterinary);
}