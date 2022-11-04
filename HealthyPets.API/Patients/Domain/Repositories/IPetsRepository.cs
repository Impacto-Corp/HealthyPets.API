using HealthyPets.API.Patients.Domain.Model;

namespace HealthyPets.API.Patients.Domain.Repositories;

public interface IPetsRepository
{
    Task<IEnumerable<Pets>> ListAsync();
    Task AddAsync(Pets pet);
    Task<Pets> FindByIdAsync(int id);
    void Update(Pets pet);
    void Remove(Pets pet);
}