using AutoMapper;
using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.MedicalRecords.Resources;

namespace HealthyPets.API.MedicalRecords.Mapping;

public class ResourceToModelProfile:Profile
{
    public ResourceToModelProfile()
    {
        CreateMap<SaveEvaluationResource, Evaluation>();
    }
}