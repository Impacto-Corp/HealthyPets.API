using HealthyPets.API.Security.Authorization.Handlers.Interfaces;
using HealthyPets.API.Security.Authorization.Setting;
using HealthyPets.API.Security.Domain.Services;
using Microsoft.Extensions.Options;

namespace HealthyPets.API.Security.Authorization.Middleware;

public class JwtMiddleware
{
    private readonly RequestDelegate _next;
    private readonly AppsSettings _appSettings;

    public JwtMiddleware(RequestDelegate next, IOptions<AppsSettings> appSettings)
    {
        _next = next;
        _appSettings = appSettings.Value;
    }

    public async Task Invoker(
        HttpContext context,
        IUserService userService,
        IJwtHandler handler)
    {
        var token = context.Request.Headers["Authorization"]
            .FirstOrDefault()?
            .Split(" ")
            .Last();

        var userId = handler.ValidateToken(token);

        if (userId != null)
            context.Items["User"] = await userService.GetByIdAsync(userId.Value);

        await _next(context);

    }
}