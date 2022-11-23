using HealthyPets.API.Appointments.Domain.Model;

namespace HealthyPets.API.Appointments.Domain.Repositories;

public interface IExamRepository
{
    Task<IEnumerable<Exam>> ListAsync();
    Task AddAsync(Exam exam);
    Task<Exam> FindByIdAsync(int id);
    void Update(Exam exam);
    void Remove(Exam exam);
}