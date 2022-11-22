using AutoMapper;
using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Resource;

namespace HealthyPets.API.Profiles.Mapping;

public class ModelToResourceProfile: Profile
{
    protected ModelToResourceProfile()
    {
        CreateMap<Client, ClientResource>();
    }
}