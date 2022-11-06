using System.ComponentModel.DataAnnotations;

namespace HealthyPets.API.Profiles.Resource;

public class SaveVetResource
{
    [Required]
    public string Name { get; set; }
}