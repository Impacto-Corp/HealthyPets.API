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
        return await _context.Evaluation.ToListAsync();
    }

    public async Task AddAsync(Evaluation evaluation)
    {
        await _context.Evaluation.AddAsync(evaluation);
    }

    public async Task<Evaluation> FindByIdAsync(int id)
    {
        return await _context.Evaluation.FindAsync(id);
    }

    public void Update(Evaluation evaluation)
    {
        _context.Evaluation.Update(evaluation);
    }

    public void Remove(Evaluation evaluation)
    {
        _context.Evaluation.Remove(evaluation);
    }
}