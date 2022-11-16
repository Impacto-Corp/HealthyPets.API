using AutoMapper;
using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.Appointments.Resources;

namespace HealthyPets.API.Appointments.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {       //      < origen, destino >
        CreateMap<Appointment, AppointmentResource>();
        CreateMap<Exam, ExamResource>();
    }
}
