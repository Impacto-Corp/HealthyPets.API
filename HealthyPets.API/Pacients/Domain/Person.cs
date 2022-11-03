namespace HealthyPets.API.Pacients.Domain;

public class Person
{
    public int Id { get; set; }
    public string Name{ get; set; }
    public AnimalClass Pet{ get; set; }
}