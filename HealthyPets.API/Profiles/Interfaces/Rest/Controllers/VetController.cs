using System.Net.Mime;
using AutoMapper;
using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Repositories;
using HealthyPets.API.Profiles.Domain.Services;
using HealthyPets.API.Profiles.Domain.Services.Communication;
using HealthyPets.API.Profiles.Resource;
using HealthyPets.API.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPets.API.Profiles.Interfaces.Rest.Controllers;
[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class VetController:ControllerBase
{
    private readonly IVetService _vetService;
    private readonly IMapper _mapper;

    public VetController(IVetService vetService, IMapper mapper)
    {
        _vetService = vetService;
        _mapper = mapper;
    }
    [HttpGet]
    public async Task<IEnumerable<VetResource>> GetAllAsync()
    {
        var vet = await _vetService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Vet>, IEnumerable<VetResource>>(vet);
        return resources;
        
    }
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveVetResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var vet = _mapper.Map<SaveVetResource, Vet  >(resource);
        var result = await _vetService.SaveAsync(vet);

        if (!result.Success)
            return BadRequest(result.Message);

        var vetResource = _mapper.Map<Vet, VetResource>(result.Resource);
        return Created(nameof(PostAsync), vetResource);
    }
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveVetResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var vet = _mapper.Map<SaveVetResource, Vet>(resource);
        var result = await _vetService.UpdateAsync(id, vet);

        if (!result.Success)
            return BadRequest(result.Message);
        var vetResource = _mapper.Map<Vet, VetResource>(result.Resource);
        return Ok(vetResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _vetService.DeleteAsync(id);
        if (!result.Success)
            return BadRequest(result.Message);

        var vetResource = _mapper.Map<Vet, VetResource>(result.Resource);
        return Ok(vetResource);
    }

}