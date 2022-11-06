using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Repositories;
using HealthyPets.API.Shared.Persistence.Contexts;
using HealthyPets.API.Shared.Persistence.Repositories;

namespace HealthyPets.API.Profiles.Persistence.Repositories;

public class DoctorRepository : BaseRepository, IDoctorRepository
{
    public DoctorRepository(AppDbContext context) : base(context)
    {
    }

    public Task<IEnumerable<Doctor>> ListAsync()
    {
        throw new NotImplementedException();
    }

    public Task AddAsync(Doctor doctor)
    {
        throw new NotImplementedException();
    }

    public Task<Doctor> FindByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public void Update(Doctor doctor)
    {
        throw new NotImplementedException();
    }

    public void Remove(Doctor doctor)
    {
        throw new NotImplementedException();
    }
}