using System.ComponentModel.DataAnnotations;

namespace HealthyPets.API.Profiles.Resource;

public class SaveDoctorResource
{
    [Required]
    public string Name { get; set; }
}