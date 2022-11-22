using System.ComponentModel.DataAnnotations;

namespace HealthyPets.API.Profiles.Resource;

public class SaveClientResource
{
    [Required]
    public string Name { get; set; }
}