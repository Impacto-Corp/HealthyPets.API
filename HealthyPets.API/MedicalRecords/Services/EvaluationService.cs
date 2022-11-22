using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.MedicalRecords.Domain.Repositories;
using HealthyPets.API.MedicalRecords.Domain.Services;
using HealthyPets.API.MedicalRecords.Domain.Services.Communication;
using HealthyPets.API.Shared.Domain.Repositories;

namespace HealthyPets.API.MedicalRecords.Services;

public class EvaluationService:IEvaluationService
{
    private readonly IEvaluationRepository _evaluationRepository;
    private readonly IUnitOfWork _unitOfWork;

    public EvaluationService(IUnitOfWork unitOfWork, IEvaluationRepository evaluationRepository)
    {
        _unitOfWork = unitOfWork;
        _evaluationRepository = evaluationRepository;
    }

    public async Task<IEnumerable<Evaluation>> ListAsync()
    {
        return await _evaluationRepository.ListAsync();
    }

    public async Task<IEnumerable<Evaluation>> ListByClientIdAsync(int clientId)
    {
        return await _evaluationRepository.FindByClientIdAsync(clientId);
    }

    public async Task<EvaluationResponse> SaveAsync(Evaluation evaluation)
    {
        try
        {
            await _evaluationRepository.AddAsync(evaluation);
            await _unitOfWork.CompleteAsync();
            return new EvaluationResponse(evaluation);
        }
        catch (Exception e)
        {
            return new EvaluationResponse($"An error occurred while saving the evaluation:{e.Message}");
        }
    }

    public async Task<EvaluationResponse> UpdateAsync(int id, Evaluation evaluation)
    {
        var existingEvaluation = await _evaluationRepository.FindByIdAsync(id);
        if (existingEvaluation==null)
        {
            return new EvaluationResponse("Evaluation not found.");
        }

        existingEvaluation.Name = evaluation.Name;
        try
        {
            _evaluationRepository.Update(existingEvaluation);
            await _unitOfWork.CompleteAsync();

            return new EvaluationResponse(existingEvaluation);
        }
        catch (Exception e)
        {
            return new EvaluationResponse($"An error occurred while updating the evaluation");
        }
    }

    public async Task<EvaluationResponse> DeleteAsync(int id)
    {
        var existingEvaluation = await _evaluationRepository.FindByIdAsync(id);
        if (existingEvaluation == null)
        {
            return new EvaluationResponse("Evaluation not found.");
        }

        try
        {
            _evaluationRepository.Remove(existingEvaluation);
            await _unitOfWork.CompleteAsync();
            return new EvaluationResponse(existingEvaluation);

        }
        catch (Exception e)
        {
            return new EvaluationResponse($"An error occurred while deleting the category:{e.Message}");
        }
    }
}