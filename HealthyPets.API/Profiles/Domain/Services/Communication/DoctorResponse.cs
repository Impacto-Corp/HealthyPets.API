using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Shared.Domain.Services.Communication;

namespace HealthyPets.API.Profiles.Domain.Services.Communication;

public class DoctorResponse: BaseResponse<Doctor>
{
    public DoctorResponse(string message) : base(message)
    {
    }

    public DoctorResponse(Doctor resource) : base(resource)
    {
    }
}