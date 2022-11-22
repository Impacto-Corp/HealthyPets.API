using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Shared.Domain.Services.Communication;

namespace HealthyPets.API.Patients.Domain.Services.Communications;

public class PetResponse : BaseResponse<Pet>
{
    public PetResponse(string message) : base(message)
    {
    }

    public PetResponse(Pet resource) : base(resource)
    {
    }
}