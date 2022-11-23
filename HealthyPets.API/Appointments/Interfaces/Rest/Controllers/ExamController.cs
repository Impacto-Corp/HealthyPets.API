using System.Net.Mime;
using AutoMapper;
using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.Appointments.Domain.Service;
using HealthyPets.API.Appointments.Resources;
using HealthyPets.API.Shared.Extensions;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPets.API.Appointments.Interfaces.Rest.Controllers;


[ApiController]
[Route("/api/V1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class ExamController : ControllerBase
{
    private readonly IExamService _examService;
    private readonly IMapper _mapper;

    public ExamController(IExamService examService, IMapper mapper)
    {
        _examService = examService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<ExamResource>> GetAllAsync()
    {
        var exams = await _examService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Exam>, IEnumerable<ExamResource>>(exams);
        return resources; 
    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveExamResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var exam = _mapper.Map<SaveExamResource, Exam>(resource);
        var result = await _examService.SaveAsync(exam);

        if (!result.Success)
            return BadRequest(result.Message);
        
        var examResource = _mapper.Map<Exam, ExamResource>(result.Resource); 
        return Created(nameof(PostAsync), examResource);
    }
    
    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveExamResource resource)
    {
        if(!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        
        var exam = _mapper.Map<SaveExamResource, Exam>(resource); 

        var result = await _examService.UpdateAsync(id, exam);

        if (!result.Success)
            return BadRequest(result.Message);
        
        var examResource= _mapper.Map<Exam, ExamResource>(result.Resource);
        return Ok(examResource); 
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _examService.DeleteAsync(id);
        
        if(!result.Success)
            return BadRequest(result.Message); 
        
        var examResource= _mapper.Map<Exam, ExamResource>(result.Resource);
        return Ok(examResource); 
    }
    
}