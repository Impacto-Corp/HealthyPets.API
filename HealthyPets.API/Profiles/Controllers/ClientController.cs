using System.Net.Mime;
using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPets.API.Profiles.Controllers;
[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class ClientController:ControllerBase

{
    private readonly IClientService _clientService;

    public ClientController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpGet]
    public async Task<IEnumerable<Client>> GetAllAsync()
    {
        var client = await _clientService.ListAsync();
        return client;
    }
}