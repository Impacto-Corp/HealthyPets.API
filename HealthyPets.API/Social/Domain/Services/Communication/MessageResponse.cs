using HealthyPets.API.Shared.Domain.Services.Communication;
using HealthyPets.API.Social.Domain.Models;

namespace HealthyPets.API.Social.Domain.Services.Communication;

public class MessageResponse : BaseResponse<Messages>
{
    public MessageResponse(string message) : base(message)
    {
    }

    public MessageResponse(Messages resource) : base(resource)
    {
    }
}