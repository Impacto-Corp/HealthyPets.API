namespace HealthyPets.API.Shared.Domain.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}