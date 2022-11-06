using AutoMapper;
using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.Appointments.Resources;

namespace HealthyPets.API.Appointments.Mapping;

public class ResourceToModelProfile : Profile
{
    protected ResourceToModelProfile()
    {
        CreateMap<SaveAppointmentResource, Appointment>();
    }
}