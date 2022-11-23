using HealthyPets.API.Security.Domain.Model;

namespace HealthyPets.API.Security.Authorization.Handlers.Interfaces;

public interface IJwtHandler
{
    public string GenerateToken(User user);
    public int? ValidateToken(string token);
}