using HealthyPets.API.Patients.Domain.Model;

namespace HealthyPets.API.Patients.Domain.Services;

public interface IPersonsService
{
    Task<IEnumerable<Person>> ListAsync();
}