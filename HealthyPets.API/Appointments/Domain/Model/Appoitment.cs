using HealthyPets.API.Pacients.Domain;

namespace HealthyPets.API.Appointments.Domain.Model;

public class Appoitment
{
    public int Id { get; set; }
    public Person Client { get; set; }
    public AnimalClass Pet { get; set; }
    
}