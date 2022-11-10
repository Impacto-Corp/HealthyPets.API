using AutoMapper;
using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Patients.Resources;

namespace HealthyPets.API.Patients.Mapping;

public class ModelToResourceProfile : Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Pet, PetResource>();
    }
}