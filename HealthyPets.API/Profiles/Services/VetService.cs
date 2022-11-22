using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Repositories;
using HealthyPets.API.Profiles.Domain.Services;
using HealthyPets.API.Profiles.Domain.Services.Communication;
using HealthyPets.API.Shared.Domain.Repositories;

namespace HealthyPets.API.Profiles.Services;

public class VetService: IVetService
{
    private readonly IVetRepository _vetRepository;
    private readonly IUnitOfWork _unitOfWork;

    public VetService(IVetRepository vetRepository, IUnitOfWork unitOfWork)
    {
        _vetRepository = vetRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Vet>> ListAsync()
    {
        return await _vetRepository.ListAsync();    }

    public async Task<VetResponse> SaveAsync(Vet vet)
    {
        try
        {
            await _vetRepository.AddAsync(vet);
            await _unitOfWork.CompleteAsync();
            return new VetResponse(vet);
        }
        catch (Exception e)
        {
            return new VetResponse($"An error occurred while saving the vet: {e.Message}");
        }  
    }

    public async Task<VetResponse> UpdateAsync(int id, Vet vet)
    {
        var existingVet = await _vetRepository.FindByIdAsync(id);
        if (existingVet == null)
            return new VetResponse("Vet not found.");
        existingVet.Name = vet.Name;
       
        try
        {
            _vetRepository.Update(existingVet);
            await _unitOfWork.CompleteAsync();

            return new VetResponse(existingVet);
        }
        catch (Exception e)
        {
            return new VetResponse($"An error occurred while the vet: {e.Message}");
        }
    }

    public async Task<VetResponse> DeleteAsync(int id)
    {
        var existingVet = await _vetRepository.FindByIdAsync(id);
        if (existingVet == null)
            return new VetResponse("Vet not found");
        try
        {
            _vetRepository.Remove(existingVet);
            await _unitOfWork.CompleteAsync();
            return new VetResponse(existingVet);
        }
        catch (Exception e)
        {
            return new VetResponse($"An error occurred while deleting the vet: {e.Message}");

        }
    }
    
}