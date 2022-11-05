using HealthyPets.API.MedicalRecords.Domain;
using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Profiles.Domain.Model;

namespace HealthyPets.API.Appointments.Domain.Model;

public class Appointment
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public Client Client { get; set; }
    public Pets Pet { get; set; }
    public Evaluation Evaluation { get; set; }
    
}