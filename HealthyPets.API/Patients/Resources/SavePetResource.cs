using System.ComponentModel.DataAnnotations;
namespace HealthyPets.API.Patients.Resources;

public class SavePetResource
{
    [Required]
    public string Name { get; set; }
}