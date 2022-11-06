using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Services;
using HealthyPets.API.Profiles.Domain.Services.Communication;

namespace HealthyPets.API.Profiles.Services;

public class DoctorService: IDoctorServices
{
    public Task<IEnumerable<Doctor>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task<DoctorResponse> SaveAsync(Doctor doctor)
    {
        throw new NotImplementedException();
    }

    public Task<DoctorResponse> UpdateAsync(int id, Doctor doctor)
    {
        throw new NotImplementedException();
    }

    public Task<DoctorResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}