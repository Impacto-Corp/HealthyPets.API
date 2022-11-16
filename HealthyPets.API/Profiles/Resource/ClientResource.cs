using HealthyPets.API.Patients.Domain.Model;

namespace HealthyPets.API.Profiles.Resource;

public class ClientResource
{
    public int Id { get; set; }
    public string Name{ get; set; }
    
    public string LastName { get; set; }
    
    public string Email { get; set; }
    
    public string Address { get; set; }
    
    public long Ruc { get; set; }
    
    public long Phone { get; set; }
    
    public Pet Pet{ get; set; }
    
    public long UserId { get; set; }

}