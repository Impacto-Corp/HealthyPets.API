using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.Appointments.Domain.Repositories;
using HealthyPets.API.Shared.Persistence.Contexts;
using HealthyPets.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HealthyPets.API.Appointments.Persistence.Repositories;

public class AppointmentRepository : BaseRepository, IAppointmentRepository
{
    public AppointmentRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Appointment>> ListAsync()
    {
        return await _context.Appointments.ToListAsync();
    }

    public async Task AddAsync(Appointment appointment)
    {
        await _context.Appointments.AddAsync(appointment);
    }

    public async Task<Appointment> FindByIdAsync(int id)
    {
        return await _context.Appointments.FindAsync(id);
    }

    public void Update(Appointment appointment)
    {
        _context.Appointments.Update(appointment);
    }

    public void Remove(Appointment appointment)
    {
        _context.Appointments.Remove(appointment);
    }
}