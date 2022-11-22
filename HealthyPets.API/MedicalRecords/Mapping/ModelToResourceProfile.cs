using AutoMapper;
using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.MedicalRecords.Resources;

namespace HealthyPets.API.MedicalRecords.Mapping;

public class ModelToResourceProfile: Profile
{
    public ModelToResourceProfile()
    {
        CreateMap<Evaluation, EvaluationResource>();
    }
}