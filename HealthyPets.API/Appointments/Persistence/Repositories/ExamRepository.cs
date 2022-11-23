using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.Appointments.Domain.Repositories;
using HealthyPets.API.Shared.Persistence.Contexts;
using HealthyPets.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HealthyPets.API.Appointments.Persistence.Repositories;

public class ExamRepository : BaseRepository, IExamRepository
{
    public ExamRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Exam>> ListAsync()
    {
        return await _context.Exams.ToListAsync();
    }

    public async Task AddAsync(Exam exam)
    {
        await _context.Exams.AddAsync(exam);
    }

    public async Task<Exam> FindByIdAsync(int id)
    {
        return await _context.Exams.FindAsync(id);
    }

    public void Update(Exam exam)
    {
        _context.Exams.Update(exam);
    }

    public void Remove(Exam exam)
    {
        _context.Exams.Remove(exam);
    }
}