using HealthyPets.API.Social.Domain.Models;
using HealthyPets.API.Social.Domain.Services.Communication;

namespace HealthyPets.API.Social.Domain.Services;

public interface IMessageService
{
    Task<IEnumerable<Message>> ListAsync();
    Task<MessageResponse> SaveAsync(Message message);
    Task<MessageResponse> UpdateAsync(int id, Message message);
    Task<MessageResponse> DeleteAsync(int id);
}