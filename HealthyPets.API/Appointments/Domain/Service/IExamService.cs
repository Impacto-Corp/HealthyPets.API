using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.Appointments.Domain.Service.Communication;

namespace HealthyPets.API.Appointments.Domain.Service;

public interface IExamService
{
    Task<IEnumerable<Exam>> ListAsync();
    Task<ExamResponse> SaveAsync(Exam exam);
    Task<ExamResponse> UpdateAsync(int id, Exam exam);
    Task<ExamResponse> DeleteAsync(int id);
}