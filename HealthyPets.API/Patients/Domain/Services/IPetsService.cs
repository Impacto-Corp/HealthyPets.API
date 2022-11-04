using HealthyPets.API.Patients.Domain.Model;

namespace HealthyPets.API.Patients.Domain.Services;

public interface IPetsService
{
    Task<IEnumerable<Pets>> ListAsync();
}