using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Services.Communication;

namespace HealthyPets.API.Profiles.Domain.Services;

public interface IVetService
{
    Task<IEnumerable<Vet>> ListAsync();
    Task<VetResponse> SaveAsync(Vet vet);
    Task<VetResponse> UpdateAsync(int id, Vet vet);
    Task<VetResponse> DeleteAsync(int id);

}