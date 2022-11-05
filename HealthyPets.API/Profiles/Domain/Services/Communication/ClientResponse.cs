using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Shared.Domain.Services.Communication;

namespace HealthyPets.API.Profiles.Domain.Services.Communication;

public class ClientResponse: BaseResponse<Client>
{
    public ClientResponse(string message) : base(message)
    {
        
    }

    public ClientResponse(Client resource) : base(resource)
    {
        
    }
}