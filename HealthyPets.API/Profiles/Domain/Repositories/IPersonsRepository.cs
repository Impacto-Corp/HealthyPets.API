using HealthyPets.API.Profiles.Domain.Model;

namespace HealthyPets.API.Profiles.Domain.Repositories;

public interface IPersonsRepository
{
    Task<IEnumerable<Person>> ListAsync();
    Task AddAsync(Person person);
    Task<Person> FindByIdAsync(int id);
    void Update(Person person);
    void Remove(Person person);
}