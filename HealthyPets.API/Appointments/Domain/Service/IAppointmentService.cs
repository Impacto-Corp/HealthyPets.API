using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.Appointments.Domain.Service.Communication;

namespace HealthyPets.API.Appointments.Domain.Service;

public interface IAppointmentService
{
    Task<IEnumerable<Appointment>> ListAsync();
    Task<AppointmentResponse> SaveAsync(Appointment appointment);
    Task<AppointmentResponse> UpdateAsync(int id, Appointment appointment);
    Task<AppointmentResponse> DeleteAsync(int id);
}