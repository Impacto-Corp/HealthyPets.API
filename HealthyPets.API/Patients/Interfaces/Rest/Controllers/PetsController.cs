using AutoMapper;
using HealthyPets.API.Patients.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPets.API.Patients.Interfaces.Rest.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class PetsController
{
    private readonly IPetsService _petsService;
    private readonly IMapper _mapper;
    
    public PetsController(IPetsService petsService, IMapper mapper)
    {
        _petsService = petsService;
        _mapper=mapper;
    }
}