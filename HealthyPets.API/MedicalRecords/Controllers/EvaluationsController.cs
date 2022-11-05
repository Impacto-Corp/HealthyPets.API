using System.Net.Mime;
using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.MedicalRecords.Domain.Services;
using HealthyPets.API.MedicalRecords.Domain.Services.Communication;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPets.API.MedicalRecords.Controllers;

[ApiController]
[Route("/api/v1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class EvaluationsController:ControllerBase
{
    private readonly IEvaluationService _evaluationService;

    public EvaluationsController(IEvaluationService evaluationService)
    {
        _evaluationService = evaluationService;
    }
    
    [HttpGet]
    public async Task<IEnumerable<Evaluation>> GetAllAsync()
    {
        var evaluations = await _evaluationService.ListAsync();
        return evaluations;
    }
    
}