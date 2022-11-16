using System.ComponentModel.DataAnnotations;
namespace HealthyPets.API.Appointments.Resources;

public class SaveExamResource
{
    [Required] 
    public DateTime Date { get; set; }
}