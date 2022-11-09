using HealthyPets.API.Shared.Domain.Repositories;
using HealthyPets.API.Social.Domain.Models;
using HealthyPets.API.Social.Domain.Repositories;
using HealthyPets.API.Social.Domain.Services;
using HealthyPets.API.Social.Domain.Services.Communication;

namespace HealthyPets.API.Social.Services;

public class MessagesService : IMessagesService
{
    private readonly IMessagesRepository _messagesRepository;
    private readonly IUnitOfWork _unitOfWork;
    public async Task<IEnumerable<Messages>> ListAsync()
    {
        return await _messagesRepository.ListAsync();
    }

    public async Task<MessageResponse> SaveAsync(Messages messages)
    {
        try
        {
            await _messagesRepository.AddAsync(messages);
            await _unitOfWork.CompleteAsync();
            return new MessageResponse(messages);
        }
        catch (Exception e)
        {
            return new MessageResponse($"An error occurred while saving the evaluation:{e.Message}");
        }
    }

    public Task<MessageResponse> UpdateAsync(int id, Messages messages)
    {
        throw new NotImplementedException();
    }

    public Task<MessageResponse> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
}