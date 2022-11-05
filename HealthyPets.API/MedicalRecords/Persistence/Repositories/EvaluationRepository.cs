using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.MedicalRecords.Domain.Repositories;
using HealthyPets.API.Shared.Persistence.Contexts;
using HealthyPets.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

namespace HealthyPets.API.MedicalRecords.Persistence.Repositories;

public class EvaluationRepository: BaseRepository, IEvaluationRepository
{
    public EvaluationRepository(AppDbContext context) : base(context)
    {
    }

    public async Task<IEnumerable<Evaluation>> ListAsync()
    {
        return await _context.Evaluations.ToListAsync();
    }

    public async Task AddAsync(Evaluation evaluation)
    {
        await _context.Evaluations.AddAsync(evaluation);
    }

    public async Task<Evaluation> FindByIdAsync(int id)
    {
        return await _context.Evaluations.FindAsync(id);
    }

    public void Update(Evaluation evaluation)
    {
        _context.Evaluations.Update(evaluation);
    }

    public void Remove(Evaluation evaluation)
    {
        _context.Evaluations.Remove(evaluation);
    }
}