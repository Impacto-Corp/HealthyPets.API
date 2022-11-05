using AutoMapper;
using HealthyPets.API.Profiles.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPets.API.Profiles.Interfaces.Rest.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class ClientController
{
    private readonly IClientService _clientService;
    private readonly IMapper _mapper;

    public ClientController(IClientService clientService, IMapper mapper)
    {
        _clientService = clientService;
        _mapper=mapper;
    }
}