using System.Net.Mime;
using AutoMapper;
using HealthyPets.API.Social.Domain.Models;
using HealthyPets.API.Social.Domain.Services;
using HealthyPets.API.Social.Resources;
using HealthyPets.API.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPets.API.Social.Interfaces.Rest.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class MessagesController : ControllerBase
{
    private readonly IMessagesService _messagesService;
    private readonly IMapper _mapper;
    
    public MessagesController(IMessagesService messagesService, IMapper mapper)
    {
        _messagesService = messagesService;
        _mapper=mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<Messages>> GetAllAsync()
    {
        var message = await _messagesService.ListAsync();
        return message;
    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveMessagesResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var evaluation = _mapper.Map<SaveMessagesResource, Messages>(resource);
        var result = await _messagesService.SaveAsync(evaluation);

        if (!result.Success)
            return BadRequest(result.Message);

        var evaluationResource = _mapper.Map<Messages, SaveMessagesResource>(result.Resource);
        return Created(nameof(PostAsync), evaluationResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveMessagesResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var evaluation = _mapper.Map<SaveMessagesResource, Messages>(resource);
        var result = await _messagesService.UpdateAsync(id, evaluation);

        if (!result.Success)
            return BadRequest(result.Message);
        var evaluationResource = _mapper.Map<Messages, MessagesResource>(result.Resource);
        return Ok(evaluationResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _messagesService.DeleteAsync(id);
        if (!result.Success)
            return BadRequest(result.Message);

        var evaluationResource = _mapper.Map<Messages, MessagesResource>(result.Resource);
        return Ok(evaluationResource);
    }
}