using AutoMapper;
using HealthyPets.API.Security.Domain.Model;
using HealthyPets.API.Security.Domain.Services.Communication;
using HealthyPets.API.Security.Resources;

namespace HealthyPets.API.Security.Mapping;

public class ModelToResourceProfile: Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<User, AuthenticateResponse>();
        CreateMap<User, UserResource>();
    }
}