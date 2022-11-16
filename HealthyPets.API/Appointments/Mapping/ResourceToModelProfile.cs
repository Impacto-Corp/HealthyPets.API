using AutoMapper;
using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.Appointments.Resources;

namespace HealthyPets.API.Appointments.Mapping;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveAppointmentResource, Appointment>();
    }
}