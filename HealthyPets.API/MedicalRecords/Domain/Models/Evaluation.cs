using HealthyPets.API.Patients.Domain.Model;

namespace HealthyPets.API.MedicalRecords.Domain.Models;

public class Evaluation
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Report { get; set; }
    public Pet Pet { get; set; }
}