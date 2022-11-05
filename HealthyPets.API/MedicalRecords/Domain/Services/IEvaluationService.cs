using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.MedicalRecords.Persistence.Repositories;

namespace HealthyPets.API.MedicalRecords.Domain.Services;

public interface IEvaluationService
{
    Task<IEnumerable<Evaluation>> ListAsync();
}