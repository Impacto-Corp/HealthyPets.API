using AutoMapper;
using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Resource;

namespace HealthyPets.API.Profiles.Mapping;

public class ResourceToModelProfile: Profile
{
    protected ResourceToModelProfile()
    {
        CreateMap<SaveClientResource, Client>();
    }
}