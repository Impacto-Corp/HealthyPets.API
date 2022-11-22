using System.Net.Mime;
using AutoMapper;
using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.MedicalRecords.Domain.Services;
using HealthyPets.API.MedicalRecords.Domain.Services.Communication;
using HealthyPets.API.MedicalRecords.Resources;
using HealthyPets.API.Shared.Extensions;
using HealthyPets.API.Shared.Persistence.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPets.API.MedicalRecords.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class EvaluationsController:ControllerBase
{
    private readonly IEvaluationService _evaluationService;
    private readonly IMapper _mapper;

    public EvaluationsController(IEvaluationService evaluationService, IMapper mapper)
    {
        _evaluationService = evaluationService;
        _mapper = mapper;
    }
    
    [HttpGet]
    public async Task<IEnumerable<EvaluationResource>> GetAllAsync()
    {
        var evaluations = await _evaluationService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Evaluation>, IEnumerable<EvaluationResource>>(evaluations);
        return resources;
    }

    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveEvaluationResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var evaluation = _mapper.Map<SaveEvaluationResource, Evaluation>(resource);
        var result = await _evaluationService.SaveAsync(evaluation);

        if (!result.Success)
            return BadRequest(result.Message);

        var evaluationResource = _mapper.Map<Evaluation, EvaluationResource>(result.Resource);
        return Created(nameof(PostAsync), evaluationResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveEvaluationResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var evaluation = _mapper.Map<SaveEvaluationResource, Evaluation>(resource);
        var result = await _evaluationService.UpdateAsync(id, evaluation);

        if (!result.Success)
            return BadRequest(result.Message);
        var evaluationResource = _mapper.Map<Evaluation, EvaluationResource>(result.Resource);
        return Ok(evaluationResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _evaluationService.DeleteAsync(id);
        if (!result.Success)
            return BadRequest(result.Message);

        var evaluationResource = _mapper.Map<Evaluation, EvaluationResource>(result.Resource);
        return Ok(evaluationResource);
    }

}