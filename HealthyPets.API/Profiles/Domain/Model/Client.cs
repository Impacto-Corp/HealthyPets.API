using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.Patients.Domain.Model;

namespace HealthyPets.API.Profiles.Domain.Model;

public class Client
{
    public Client()
    {
        Appointments = new List<Appointment>();
    }
    //Properties
    public int Id { get; set; }
    public string Name{ get; set; }
    
    public string LastName { get; set; }
    
    public string Email { get; set; }
    
    public string Address { get; set; }
    
    public long Ruc { get; set; }
    
    public long Phone { get; set; }
    
    public Pet Pet{ get; set; }
    
    public long UserId { get; set; }
    
    
    //Relationships
    public IList<Appointment> Appointments { get; set; }

    }
   