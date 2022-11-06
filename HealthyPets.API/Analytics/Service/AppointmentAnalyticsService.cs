using HealthyPets.API.Analytics.Domain.Service;
using HealthyPets.API.Appointments.Interfaces.Internal;

namespace HealthyPets.API.Analytics.Service;

public class AppointmentsAnalyticsService : IAppointmentAnalyticsService
{
    private readonly IAppointmentContextFacade _appointmentContext;
    
    public AppointmentsAnalyticsService(IAppointmentContextFacade appointmentContext)
    {
        _appointmentContext = appointmentContext;
    }

    public int TotalAppintmentsCount()
    {
        return _appointmentContext.TotalAppointments();
    }
}