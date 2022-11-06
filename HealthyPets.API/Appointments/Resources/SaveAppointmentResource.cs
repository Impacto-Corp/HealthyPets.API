using System.ComponentModel.DataAnnotations;

namespace HealthyPets.API.Appointments.Resources;

public class SaveAppointmentResource
{
    [Required]
    public DateTime Date { get; set; }
}