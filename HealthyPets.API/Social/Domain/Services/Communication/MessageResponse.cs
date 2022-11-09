using HealthyPets.API.Shared.Domain.Services.Communication;
using HealthyPets.API.Social.Domain.Models;

namespace HealthyPets.API.Social.Domain.Services.Communication;

public class MessageResponse : BaseResponse<Message>
{
    public MessageResponse(string message) : base(message)
    {
    }

    public MessageResponse(Message resource) : base(resource)
    {
    }
}