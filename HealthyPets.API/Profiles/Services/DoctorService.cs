using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Repositories;
using HealthyPets.API.Profiles.Domain.Services;
using HealthyPets.API.Profiles.Domain.Services.Communication;
using HealthyPets.API.Shared.Domain.Repositories;

namespace HealthyPets.API.Profiles.Services;

public class DoctorService: IDoctorServices
{
    
    private readonly IDoctorRepository _doctorRepository;
    private readonly IUnitOfWork _unitOfWork;

    public DoctorService(IDoctorRepository doctorRepository, IUnitOfWork unitOfWork)
    {
        _doctorRepository = doctorRepository;
        _unitOfWork = unitOfWork;
    }

    public async Task<IEnumerable<Doctor>> ListAsync()
    {
        return await _doctorRepository.ListAsync();
    }

    public async Task<DoctorResponse> SaveAsync(Doctor doctor)
    {
        try
        {
            await _doctorRepository.AddAsync(doctor);
            await _unitOfWork.CompleteAsync();
            return new DoctorResponse(doctor);
        }
        catch (Exception e)
        {
            return new DoctorResponse($"An error occurred while saving the doctor: {e.Message}");
        }    }

    public async Task<DoctorResponse> UpdateAsync(int id, Doctor doctor)
    {
        var existingDoctor = await _doctorRepository.FindByIdAsync(id);
        if (existingDoctor == null)
            return new DoctorResponse("Doctor not found.");
        existingDoctor.Name = doctor.Name;
       
        try
        {
            _doctorRepository.Update(existingDoctor);
            await _unitOfWork.CompleteAsync();

            return new DoctorResponse(existingDoctor);
        }
        catch (Exception e)
        {
            return new DoctorResponse($"An error occurred while the doctor: {e.Message}");
        }
    }

    public async Task<DoctorResponse> DeleteAsync(int id)
    {
        var existingDoctor = await _doctorRepository.FindByIdAsync(id);
        if (existingDoctor == null)
            return new DoctorResponse("Doctor not found");
        try
        {
            _doctorRepository.Remove(existingDoctor);
            await _unitOfWork.CompleteAsync();
            return new DoctorResponse(existingDoctor);
        }
        catch (Exception e)
        {
            return new DoctorResponse($"An error occurred while deleting the doctor: {e.Message}");

        }
    }
}