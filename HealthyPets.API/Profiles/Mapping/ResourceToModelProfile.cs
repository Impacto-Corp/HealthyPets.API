using AutoMapper;
using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Resource;

namespace HealthyPets.API.Profiles.Mapping;

public class ResourceToModelProfile: Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveClientResource, Client>();
        CreateMap<SaveDoctorResource, Doctor>();
        CreateMap<SaveVetResource, Vet>();
    }
}