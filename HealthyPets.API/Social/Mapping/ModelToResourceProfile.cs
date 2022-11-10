using AutoMapper;
using HealthyPets.API.Social.Domain.Models;
using HealthyPets.API.Social.Resources;

namespace HealthyPets.API.Social.Mapping;

public class ModelToResourceProfile:Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Message, MessageResource>();
    }
}