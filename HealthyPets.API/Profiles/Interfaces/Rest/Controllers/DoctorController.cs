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
public class DoctorController: ControllerBase
{
    private readonly IDoctorServices _doctorServices;
    private readonly IMapper _mapper;

    public DoctorController(IDoctorServices doctorServices, IMapper mapper)
    {
        _doctorServices = doctorServices;
        _mapper = mapper;
    }
    [HttpGet]
    public async Task<IEnumerable<DoctorResource>> GetAllAsync()
    {
        var doctor = await _doctorServices.ListAsync();
        var resources = _mapper.Map<IEnumerable<Doctor>, IEnumerable<DoctorResource>>(doctor);
        return resources;
        
    }
    
    [HttpPost]
    public async Task<IActionResult> PostAsync([FromBody] SaveDoctorResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var doctor = _mapper.Map<SaveDoctorResource, Doctor  >(resource);
        var result = await _doctorServices.SaveAsync(doctor);

        if (!result.Success)
            return BadRequest(result.Message);

        var doctorResource = _mapper.Map<Doctor, DoctorResource>(result.Resource);
        return Created(nameof(PostAsync), doctorResource);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> PutAsync(int id, [FromBody] SaveDoctorResource resource)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState.GetErrorMessages());

        var doctor = _mapper.Map<SaveDoctorResource, Doctor>(resource);
        var result = await _doctorServices.UpdateAsync(id, doctor);

        if (!result.Success)
            return BadRequest(result.Message);
        var doctorResource = _mapper.Map<Doctor, DoctorResource>(result.Resource);
        return Ok(doctorResource);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteAsync(int id)
    {
        var result = await _doctorServices.DeleteAsync(id);
        if (!result.Success)
            return BadRequest(result.Message);

        var doctorResource = _mapper.Map<Doctor, DoctorResource>(result.Resource);
        return Ok(doctorResource);
    }
}