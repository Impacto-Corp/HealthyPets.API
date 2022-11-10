using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Patients.Domain.Services.Communications;

namespace HealthyPets.API.Patients.Domain.Services;

public interface IPetService
{
    Task<IEnumerable<Pet>> ListAsync();
    Task<PetResponse> SaveAsync(Pet pet);
    Task<PetResponse> UpdateAsync(int id, Pet pet);
    Task<PetResponse> DeleteAsync(int id);
}