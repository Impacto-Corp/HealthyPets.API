using HealthyPets.API.Patients.Domain.Model;

namespace HealthyPets.API.Profiles.Domain.Model;

public class Person
{
    public int Id { get; set; }
    public string Name{ get; set; }
    public Pets Pet{ get; set; }
}