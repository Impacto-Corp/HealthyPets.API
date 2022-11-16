using System.ComponentModel.DataAnnotations;
using HealthyPets.API.Patients.Domain.Model;

namespace HealthyPets.API.Profiles.Resource;

public class SaveClientResource
{
    [Required]
    [MaxLength(200)]
    public string Name { get; set; }
    [Required]
    [MaxLength(200)]
    public string LastName { get; set; }
    [Required]
    [MaxLength(200)]
    public string Email { get; set; }
    [Required]
    [MaxLength(200)]
    public string Adress { get; set; }
    [Required]
    [MaxLength(200)]
    public string Ruc { get; set; }
    [Required]
    [MaxLength(200)]
    public string Phone { get; set; }
    [Required]
    [MaxLength(200)]
    public Pet Pet { get; set; }
    [Required]
    [MaxLength(200)]
    public long UserId { get; set; }
}


