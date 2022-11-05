namespace HealthyPets.API.Shared.Domein.Repositories;

public interface IUnitOfWork
{
    Task CompleteAsync();
}