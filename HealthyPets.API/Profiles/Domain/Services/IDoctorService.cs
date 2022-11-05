using HealthyPets.API.Profiles.Domain.Model;

namespace HealthyPets.API.Profiles.Domain.Services;

public class IDoctorService
{
    Task<IEnumerable<Doctor>> ListAsync();
}