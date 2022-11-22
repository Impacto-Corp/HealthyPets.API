using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Shared.Domain.Services.Communication;

namespace HealthyPets.API.Profiles.Domain.Services.Communication;

public class VetResponse: BaseResponse<Vet>
{
    public VetResponse(string message) : base(message)
    {
    }

    public VetResponse(Vet resource) : base(resource)
    {
    }
}