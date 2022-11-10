using AutoMapper;
using HealthyPets.API.Social.Domain.Models;
using HealthyPets.API.Social.Resources;

namespace HealthyPets.API.Social.Mapping;

public class ResourceToModelProfile : Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveMessageResource, Message>();
    }
}