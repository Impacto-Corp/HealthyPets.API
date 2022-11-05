using HealthyPets.API.Appointments.Domain.Model;

namespace HealthyPets.API.Appointments.Domain.Repositories;

public interface IAppointmentRepository
{
    Task<IEnumerable<Appointment>> ListAsync();//darme todos
    Task AddAsync(Appointment appointment);//Agregar uno
    Task<Appointment> FindByIdAsync(int id);//Buscar uno por Id
    void Update(Appointment appointment);//Actualizar
    void Remove(Appointment appointment);//Eliminar
}