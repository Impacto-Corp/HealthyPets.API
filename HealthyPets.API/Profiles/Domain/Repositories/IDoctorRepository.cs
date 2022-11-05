using HealthyPets.API.Profiles.Domain.Model;

namespace HealthyPets.API.Profiles.Domain.Repositories;

public class IDoctorRepository
{
    Task<IEnumerable<Doctor>> ListAsync();
    Task AddAsync(Doctor doctor)
    Task<Doctor> FindByIdAsync(int id);
    void Update(Doctor doctor);
    void Remove(Doctor doctor);
}