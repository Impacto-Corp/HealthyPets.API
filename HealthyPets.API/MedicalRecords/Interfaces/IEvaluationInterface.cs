using HealthyPets.API.MedicalRecords.Domain;

namespace HealthyPets.API.MedicalRecords.Interfaces;

public interface IEvaluationInterface
{
    Task<IEnumerable<Evaluation>> ListAsync();
    Task AddAsync(Evaluation evaluation);
    Task<Evaluation> FindByIdAsync(int id);
    void Update(Evaluation evaluation);
    void Remove(Evaluation evaluation);
}