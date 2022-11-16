using HealthyPets.API.Appointments.Domain.Repositories;
using HealthyPets.API.Appointments.Domain.Service;
using HealthyPets.API.Appointments.Persistence.Repositories;
using HealthyPets.API.Appointments.Services;
using HealthyPets.API.Patients.Domain.Repositories;
using HealthyPets.API.Patients.Domain.Services;
using HealthyPets.API.Patients.Persistence.Repositories;
using HealthyPets.API.Patients.Services;
using HealthyPets.API.Shared.Domain.Repositories;
using HealthyPets.API.Shared.Persistence.Contexts;
using HealthyPets.API.Shared.Persistence.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


// Add Database Connection

var connectionString = builder.Configuration
    .GetConnectionString("DefaultConnection");


builder.Services.AddDbContext<AppDbContext>(
    options => options.UseMySQL(connectionString)
        .LogTo(Console.WriteLine, LogLevel.Information)
        .EnableSensitiveDataLogging()
        .EnableDetailedErrors());

builder.Services.AddRouting(options => options.LowercaseUrls = true);

builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
builder.Services.AddScoped<IAppointmentService, AppointmentService>();

builder.Services.AddAutoMapper(
    typeof(HealthyPets.API.Appointments.Mapping.ModelToResourceProfile),
    typeof(HealthyPets.API.Appointments.Mapping.ResourceToModelProfile));




var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();