using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.Profiles.Domain.Model;

namespace HealthyPets.API.Patients.Domain.Model;

public class Pet
{
    public int Id { get; set; }
    public string Name{ get; set; }
    public string Species { get; set; }
    public Client Owner { get; set; }
    public List<Evaluation> Record { get; set; }
    public Appointment Appointment { get; set; }
}