using HealthyPets.API.Patients.Domain.Model;

namespace HealthyPets.API.Patients.Domain.Repositories;

public interface IPetsRepository
{
    Task<IEnumerable<Pet>> ListAsync();
    Task AddAsync(Pet pet);
    Task<Pet> FindByIdAsync(int id);
    void Update(Pet pet);
    void Remove(Pet pet);
}