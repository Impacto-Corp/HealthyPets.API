namespace HealthyPets.API.Profiles.Domain.Model;

public class Doctor
{
    //Properties
    public long Id { get; set; }
    public string Name{ get; set; }
    
    public string LastName { get; set; }
    
    public string Email { get; set; }
    
    public long Phone { get; set; }
}