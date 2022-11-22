using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.Shared.Domain.Services.Communication;

namespace HealthyPets.API.MedicalRecords.Domain.Services.Communication;

public class EvaluationResponse:BaseResponse<Evaluation>
{
    public EvaluationResponse(string message) : base(message)
    {
    }

    public EvaluationResponse(Evaluation resource) : base(resource)
    {
    }
}