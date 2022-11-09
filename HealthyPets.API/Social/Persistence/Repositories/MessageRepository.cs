using HealthyPets.API.Shared.Persistence.Contexts;
using HealthyPets.API.Shared.Persistence.Repositories;
using HealthyPets.API.Social.Domain.Models;
using HealthyPets.API.Social.Domain.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HealthyPets.API.Social.Persistence.Repositories;

public class MessageRepository : BaseRepository, IMessageRepository
{
    public MessageRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Message>> ListAsync()
    {
        return await _context.Messages.ToListAsync();
    }

    public async Task AddAsync(Message message)
    {
        await _context.Messages.AddAsync(message);
    }

    public async Task<Message> FindByIdAsync(int id)
    {
        return await _context.Messages.FindAsync(id);
    }

    public async void Update(Message message)
    {
        _context.Messages.Update(message);
    }

    public async void Remove(Message message)
    {
        _context.Messages.Remove(message);
    }
}