using HealthyPets.API.Shared.Domain.Repositories;
using HealthyPets.API.Social.Domain.Models;
using HealthyPets.API.Social.Domain.Repositories;
using HealthyPets.API.Social.Domain.Services;
using HealthyPets.API.Social.Domain.Services.Communication;

namespace HealthyPets.API.Social.Services;

public class MessageService : IMessageService
{
    private readonly IMessageRepository _messagesRepository;
    private readonly IUnitOfWork _unitOfWork;
    public async Task<IEnumerable<Message>> ListAsync()
    {
        return await _messagesRepository.ListAsync();
    }

    public async Task<MessageResponse> SaveAsync(Message message)
    {
        try
        {
            await _messagesRepository.AddAsync(message);
            await _unitOfWork.CompleteAsync();
            return new MessageResponse(message);
        }
        catch (Exception e)
        {
            return new MessageResponse($"An error occurred while saving the evaluation:{e.Message}");
        }
    }

    public async Task<MessageResponse> UpdateAsync(int id, Message message)
    {
        var existingMess = await _messagesRepository.FindByIdAsync(id);
        if (existingMess==null)
        {
            return new MessageResponse("Evaluation not found.");
        }

        existingMess.Content = message.Content;
        try
        {
            _messagesRepository.Update(existingMess);
            await _unitOfWork.CompleteAsync();

            return new MessageResponse(existingMess);
        }
        catch (Exception e)
        {
            return new MessageResponse($"An error occurred while updating the evaluation");
        }
    }

    public async Task<MessageResponse> DeleteAsync(int id)
    {
        var existingMess = await _messagesRepository.FindByIdAsync(id);
        if (existingMess == null)
        {
            return new MessageResponse("Evaluation not found.");
        }

        try
        {
            _messagesRepository.Remove(existingMess);
            await _unitOfWork.CompleteAsync();
            return new MessageResponse(existingMess);

        }
        catch (Exception e)
        {
            return new MessageResponse($"An error occurred while deleting the category:{e.Message}");
        }
    }
}