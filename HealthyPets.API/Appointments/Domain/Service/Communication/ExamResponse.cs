using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.Shared.Domain.Services.Communication;

namespace HealthyPets.API.Appointments.Domain.Service.Communication;

public class ExamResponse : BaseResponse<Exam>
{
    public ExamResponse(string message) : base(message)
    {
    }

    public ExamResponse(Exam resource) : base(resource)
    {
    }
}