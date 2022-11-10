using System.Net.Mime;
using AutoMapper;
using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Patients.Domain.Services;
using HealthyPets.API.Patients.Resources;
using HealthyPets.API.Shared.Extensions;
using HealthyPets.API.Shared.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPets.API.Patients.Interfaces.Rest.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class PetController : ControllerBase
{
    private readonly IPetService _petService;
    private readonly IMapper _mapper;
    
    public PetController(IPetService petService, IMapper mapper)
    {
        _petService = petService;
        _mapper=mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<Pet>> GetAllAsync()
    {
        var pets = await _petService.ListAsync();
        return pets;
    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SavePetResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var evaluation = _mapper.Map<SavePetResource, Pet>(resource);
        var result = await _petService.SaveAsync(evaluation);

        if (!result.Success)
            return BadRequest(result.Message);

        var evaluationResource = _mapper.Map<Pet, SavePetResource>(result.Resource);
        return Created(nameof(PostAsync), evaluationResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SavePetResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var evaluation = _mapper.Map<SavePetResource, Pet>(resource);
        var result = await _petService.UpdateAsync(id, evaluation);

        if (!result.Success)
            return BadRequest(result.Message);
        var evaluationResource = _mapper.Map<Pet, PetResource>(result.Resource);
        return Ok(evaluationResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _petService.DeleteAsync(id);
        if (!result.Success)
            return BadRequest(result.Message);

        var evaluationResource = _mapper.Map<Pet, PetResource>(result.Resource);
        return Ok(evaluationResource);
    }

}