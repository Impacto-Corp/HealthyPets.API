using HealthyPets.API.Patients.Domain.Model;

namespace HealthyPets.API.Appointments.Domain.Model;

public class Appointment
{
    public int Id { get; set; }
    public DateOnly Date { get; set; }
    public Person Client { get; set; }
    public Pets Pet { get; set; }
    
}