using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Patients.Domain.Repositories;
using HealthyPets.API.Patients.Domain.Services;
using HealthyPets.API.Patients.Domain.Services.Communications;
using HealthyPets.API.Shared.Domain.Repositories;

namespace HealthyPets.API.Patients.Services;

public class PetsService : IPetsService
{
    private readonly IPetsRepository _petsRepository;
    private readonly IUnitOfWork _unitOfWork;
    
    public async Task<IEnumerable<Pet>> ListAsync()
    {
        return await _petsRepository.ListAsync();
    }

    public async Task<PetResponse> SaveAsync(Pet pet)
    {
        try
        {
            await _petsRepository.AddAsync(pet);
            await _unitOfWork.CompleteAsync();
            return new PetResponse(pet);
        }
        catch (Exception e)
        {
            return new PetResponse($"An error occurred while saving the evaluation:{e.Message}");
        }
    }

    public async Task<PetResponse> UpdateAsync(int id, Pet pet)
    {
        var existingPet = await _petsRepository.FindByIdAsync(id);
        if (existingPet==null)
        {
            return new PetResponse("Evaluation not found.");
        }

        existingPet.Name = pet.Name;
        try
        {
            _petsRepository.Update(existingPet);
            await _unitOfWork.CompleteAsync();

            return new PetResponse(existingPet);
        }
        catch (Exception e)
        {
            return new PetResponse($"An error occurred while updating the evaluation");
        }
    }

    public async Task<PetResponse> DeleteAsync(int id)
    {
        var existingPet = await _petsRepository.FindByIdAsync(id);
        if (existingPet == null)
        {
            return new PetResponse("Evaluation not found.");
        }

        try
        {
            _petsRepository.Remove(existingPet);
            await _unitOfWork.CompleteAsync();
            return new PetResponse(existingPet);

        }
        catch (Exception e)
        {
            return new PetResponse($"An error occurred while deleting the category:{e.Message}");
        }
    }
}