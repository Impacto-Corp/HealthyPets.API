using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Services.Communication;

namespace HealthyPets.API.Profiles.Domain.Services;

public interface IVeterinaryService
{
    Task<IEnumerable<Veterinary>> ListAsync();
    Task<VeterinaryResponse> SaveAsync(Veterinary veterinary);
    Task<VeterinaryResponse> UpdateAsync(int id, Veterinary veterinary);
    Task<VeterinaryResponse> DeleteAsync(int id);
}