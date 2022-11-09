using System.ComponentModel.DataAnnotations;

namespace HealthyPets.API.Social.Resources;

public class SaveMessagesResource
{
    [Required]
    public string Message { get; set; }
}