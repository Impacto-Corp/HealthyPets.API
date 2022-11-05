using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.MedicalRecords.Domain.Services.Communication;
using HealthyPets.API.MedicalRecords.Persistence.Repositories;

namespace HealthyPets.API.MedicalRecords.Domain.Services;

public interface IEvaluationService
{
    Task<IEnumerable<Evaluation>> ListAsync();
    Task<EvaluationResponse> SaveAsync(Evaluation evaluation);
    Task<EvaluationResponse> UpdateAsync(int id, Evaluation evaluation);
    Task<EvaluationResponse> DeleteAsync(int id);
}