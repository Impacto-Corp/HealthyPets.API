using System.ComponentModel.DataAnnotations;

namespace HealthyPets.API.Profiles.Resource;

public class SaveDoctorResource
{
    [Required]
    public string Name { get; set; }
    [Required]
    [MaxLength(200)]
    public string LastName { get; set; }
    [Required]
    [MaxLength(200)]
    public string Email { get; set; }
    [Required]
    [MaxLength(200)]
    public string Phone { get; set; }
}