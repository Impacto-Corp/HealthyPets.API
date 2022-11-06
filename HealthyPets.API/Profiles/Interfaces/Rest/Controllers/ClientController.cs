using System.Net.Mime;
using AutoMapper;
using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Profiles.Domain.Services;
using HealthyPets.API.Profiles.Resource;
using HealthyPets.API.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPets.API.Profiles.Interfaces.Rest.Controllers;
[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class ClientController:ControllerBase

{
    private readonly IClientService _clientService;
    private readonly IMapper _mapper;
    
    public ClientController(IClientService clientService, IMapper mapper)
    {
        _clientService = clientService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<ClientResource>> GetAllAsync()
    {
        var client = await _clientService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Client>, IEnumerable<ClientResource>>(client);
        return resources;
        
    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveClientResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var client = _mapper.Map<SaveClientResource, Client  >(resource);
        var result = await _clientService.SaveAsync(client);

        if (!result.Success)
            return BadRequest(result.Message);

        var clientResource = _mapper.Map<Client, ClientResource>(result.Resource);
        return Created(nameof(PostAsync), clientResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveClientResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var client = _mapper.Map<SaveClientResource, Client>(resource);
        var result = await _clientService.UpdateAsync(id, client);

        if (!result.Success)
            return BadRequest(result.Message);
        var clientResource = _mapper.Map<Client, ClientResource>(result.Resource);
        return Ok(clientResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _clientService.DeleteAsync(id);
        if (!result.Success)
            return BadRequest(result.Message);

        var clientResource = _mapper.Map<Client, ClientResource>(result.Resource);
        return Ok(clientResource);
    }
    
}