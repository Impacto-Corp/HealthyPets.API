using HealthyPets.API.Shared.Persistence.Contexts;
using HealthyPets.API.Shared.Persistence.Repositories;
using HealthyPets.API.Social.Domain.Models;
using HealthyPets.API.Social.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HealthyPets.API.Social.Persistence.Repositories;

public class MessagesRepository : BaseRepository, IMessagesRepository
{
    public MessagesRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Messages>> ListAsync()
    {
        return await _context.Messages.ToListAsync();
    }

    public async Task AddAsync(Messages messages)
    {
        await _context.Messages.AddAsync(messages);
    }

    public async Task<Messages> FindByIdAsync(int id)
    {
        return await _context.Messages.FindAsync(id);
    }

    public async void Update(Messages messages)
    {
        _context.Messages.Update(messages);
    }

    public async void Remove(Messages messages)
    {
        _context.Messages.Remove(messages);
    }
}