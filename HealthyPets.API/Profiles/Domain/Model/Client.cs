using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.Patients.Domain.Model;

namespace HealthyPets.API.Profiles.Domain.Model;

public class Client
{
    //Properties
    public int Id { get; set; }
    public string Name { get; set; }
    public Pet Pet { get; set; }

    public List<Evaluation> Evaluations { get; set; }

}