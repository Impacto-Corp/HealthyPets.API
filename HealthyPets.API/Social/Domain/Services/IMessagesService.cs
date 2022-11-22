using HealthyPets.API.Social.Domain.Models;
using HealthyPets.API.Social.Domain.Services.Communication;

namespace HealthyPets.API.Social.Domain.Services;

public interface IMessagesService
{
    Task<IEnumerable<Messages>> ListAsync();
    Task<MessageResponse> SaveAsync(Messages messages);
    Task<MessageResponse> UpdateAsync(int id, Messages messages);
    Task<MessageResponse> DeleteAsync(int id);
}