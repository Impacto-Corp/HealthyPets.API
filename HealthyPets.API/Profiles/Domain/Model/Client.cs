using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Social.Domain.Models;

namespace HealthyPets.API.Profiles.Domain.Model;

public class Client
{
    //Properties
    public int Id { get; set; }
    public string Name{ get; set; }
    public Pet Pet{ get; set; }
    public Message Comment { get; set; }
}