using HealthyPets.API.Profiles.Domain.Model;

namespace HealthyPets.API.Social.Domain.Models;

public class Message
{
    public int Id { get; set; }
    public string Content { get; set; }
    public Client User { get; set; }
}