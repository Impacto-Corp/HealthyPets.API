using AutoMapper;
using HealthyPets.API.Social.Domain.Models;
using HealthyPets.API.Social.Resources;

namespace HealthyPets.API.Social.Mapping;

public class ModelToResourceProfile:Profile
{
    protected ModelToResourceProfile()
    {
        CreateMap<Message, MessageResource>();
    }
}