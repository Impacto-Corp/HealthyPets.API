using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.Shared.Domain.Services.Communication;

namespace HealthyPets.API.Appointments.Domain.Service.Communication;

public class AppointmentResponse : BaseResponse<Appointment>
{
    public AppointmentResponse(string message) : base(message)
    {
    }

    public AppointmentResponse(Appointment resource) : base(resource)
    {
    }
}