using System.Net.Mime;
using AutoMapper;
using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.Appointments.Domain.Service;
using HealthyPets.API.Appointments.Resources;
using Microsoft.AspNetCore.Mvc;

namespace HealthyPets.API.Appointments.Interfaces.Rest.Controllers;

[ApiController]
[Route("/api/V1/[controller]")]
[Produces(MediaTypeNames.Application.Json)]
public class AppointmentsController : ControllerBase
{
    private readonly IAppointmentService _appointmentService;
    private readonly IMapper _mapper;

    public AppointmentsController(IAppointmentService appointmentService, IMapper mapper)
    {
        _appointmentService = appointmentService;
        _mapper = mapper;
    }

    [HttpGet]
    public async Task<IEnumerable<AppointmentResource>> GetAllAsync()
    {
        var appointments = await _appointmentService.ListAsync();
        var resources = _mapper.Map<IEnumerable<Appointment>, IEnumerable<AppointmentResource>>(appointments);
        return resources; 
    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveAppointmentResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var category = _mapper.Map<SaveCategoryResource, Category>(resource);
        var result = await _categoryService.SaveAsync(category);

        if (!result.Success)
            return BadRequest(result.Message);
        
        var categoryResource = _mapper.Map<Category, CategoryResource>(result.Resource); //Convirtiendo de Category a CategoryResource
        return Created(nameof(PostAsync), categoryResource);
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
}