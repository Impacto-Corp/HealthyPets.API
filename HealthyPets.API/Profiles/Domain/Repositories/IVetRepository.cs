using HealthyPets.API.Profiles.Domain.Model;

namespace HealthyPets.API.Profiles.Domain.Repositories;

public interface IVetRepository
{
    Task<IEnumerable<Vet>> ListAsync();
    Task AddAsync(Vet vet);
    Task<Vet> FindByIdAsync(int id);
    void Update(Vet vet);
    void Remove(Vet vet);
}