using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Services.Communication;

namespace HealthyPets.API.Profiles.Domain.Services;

public interface IDoctorServices
{
    Task<IEnumerable<Doctor>> ListAsync();
    Task<DoctorResponse> SaveAsync(Doctor doctor);
    Task<DoctorResponse> UpdateAsync(int id, Doctor doctor);
    Task<DoctorResponse> DeleteAsync(int id);

}