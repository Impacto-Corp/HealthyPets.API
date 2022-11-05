namespace HealthyPets.API.Patients.Domain.Model;

public class Person
{
    public int Id { get; set; }
    public string Name{ get; set; }
    public Pets Pet{ get; set; }
}