using AutoMapper;
using Google.Protobuf.WellKnownTypes;
using HealthyPets.API.Security.Domain.Model;
using HealthyPets.API.Security.Domain.Services.Communication;
using Microsoft.Extensions.Options;
using Org.BouncyCastle.Asn1.X509;

namespace HealthyPets.API.Security.Mapping;

public class ResourceToModelProfile:Profile
{
    protected ResourceToModelProfile()
    {
        CreateMap<RegisterRequest, User>();
        CreateMap<UpdateRequest,User>()
            .ForAllMembers(options=>options.Condition(
                (source, Target, property) =>
                {
                    if (property == null) return false;
                    if (property.GetType() == typeof(string) && string.IsNullOrEmpty((string)property)) return false;
                    return true;
                }
                ));
    }
}