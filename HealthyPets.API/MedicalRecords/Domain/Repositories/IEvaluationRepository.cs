using HealthyPets.API.MedicalRecords.Domain.Models;

namespace HealthyPets.API.MedicalRecords.Domain.Repositories;

public interface IEvaluationRepository
{
    Task<IEnumerable<Evaluation>> ListAsync();
    Task AddAsync(Evaluation evaluation);
    Task<Evaluation> FindByIdAsync(int id);
    Task<IEnumerable<Evaluation>> FindByClientIdAsync(int clientId);
    void Update(Evaluation evaluation);
    void Remove(Evaluation evaluation);
}