using HealthyPets.API.Patients.Domain.Model;

namespace HealthyPets.API.Patients.Domain.Repositories;

public interface IPersonsRepository
{
    Task<IEnumerable<Person>> ListAsync();
    Task AddAsync(Person person);
    Task<Person> FindByIdAsync(int id);
    void Update(Person person);
    void Remove(Person person);
}