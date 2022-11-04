using AutoMapper;
using HealthyPets.API.Patients.Domain.Services;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPets.API.Patients.Interfaces.Rest.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
public class PersonsController
{
    private readonly IPersonsService _personsService;
    private readonly IMapper _mapper;

    public PersonsController(IPersonsService personsService, IMapper mapper)
    {
        _personsService = personsService;
        _mapper=mapper;
    }
}