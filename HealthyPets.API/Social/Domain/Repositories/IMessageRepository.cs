using HealthyPets.API.Social.Domain.Models;

namespace HealthyPets.API.Social.Domain.Repositories;

public interface IMessageRepository
{
    Task<IEnumerable<Message>> ListAsync();
    Task AddAsync(Message message);
    Task<Message> FindByIdAsync(int id);
    void Update(Message message);
    void Remove(Message message);
}