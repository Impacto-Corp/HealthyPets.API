using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Shared.Domain.Services.Communication;

namespace HealthyPets.API.Profiles.Domain.Services.Communication;

public class VeterinaryResponse: BaseResponse<Veterinary>
{
    public VeterinaryResponse(string message) : base(message)
    {
    }

    public VeterinaryResponse(Veterinary resource) : base(resource)
    {
    }
}