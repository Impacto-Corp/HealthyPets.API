using HealthyPets.API.Shared.Persistence.Contexts;
using HealthyPets.API.Shared.Persistence.Repositories;
using HealthyPets.API.Social.Domain.Models;
using HealthyPets.API.Social.Domain.Repositories;

namespace HealthyPets.API.Social.Persistence.Repositories;

public class MessagesRepository : BaseRepository, IMessagesRepository
{
    public MessagesRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Messages>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public async Task AddAsync(Messages messages)
    {
        throw new NotImplementedException();
    }

    public async Task<Messages> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public async void Update(Messages messages)
    {
        throw new NotImplementedException();
    }

    public async void Remove(Messages messages)
    {
        throw new NotImplementedException();
    }
}