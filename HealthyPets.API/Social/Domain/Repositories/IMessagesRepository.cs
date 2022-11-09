using HealthyPets.API.Social.Domain.Models;

namespace HealthyPets.API.Social.Domain.Repositories;

public interface IMessagesRepository
{
    Task<IEnumerable<Messages>> ListAsync();
    Task AddAsync(Messages messages);
    Task<Messages> FindByIdAsync(int id);
    void Update(Messages messages);
    void Remove(Messages messages);
}