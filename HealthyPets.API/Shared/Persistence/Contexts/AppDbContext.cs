using HealthyPets.API.Appointments.Domain.Model;
using HealthyPets.API.MedicalRecords.Domain;
using HealthyPets.API.MedicalRecords.Domain.Models;
using HealthyPets.API.Patients.Domain.Model;
using HealthyPets.API.Profiles.Domain.Model;
using HealthyPets.API.Shared.Extensions;
using Microsoft.EntityFrameworkCore;

namespace HealthyPets.API.Shared.Persistence.Contexts;

public class AppDbContext:DbContext
{
    public DbSet<Evaluation> Evaluations { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    public DbSet<Pet> Pets { get; set; }
    public AppDbContext(DbContextOptions options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
        
        // -------------------------- Evaluation Entity ----------------------------
        
        //Evaluation Configuration 
        builder.Entity<Evaluation>().ToTable("Evaluations");
        builder.Entity<Evaluation>().HasKey(p => p.Id);
        builder.Entity<Evaluation>().Property(p => p.Id)
            .IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Evaluation>().Property(p => p.Name)
            .IsRequired().HasMaxLength(40);

        //Fluent API
        
        
        
        
        // -------------------------- Appointment Entity ----------------------------
        builder.Entity<Appointment>().ToTable("Appointments");
        builder.Entity<Appointment>().HasKey(p => p.Id);
        builder.Entity<Appointment>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Appointment>().Property(p => p.Date).IsRequired();

        builder.Entity<Pet>().ToTable("Pets");
        builder.Entity<Pet>().HasKey(p => p.Id);
        builder.Entity<Pet>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Pet>().Property(p => p.Name).IsRequired().HasMaxLength(20);
        builder.Entity<Pet>().Property(p => p.Species).IsRequired().HasMaxLength(30);
            //Relationships
        //builder.Entity<Appointment>().HasMany(p=>p.Evaluation).WithOne(p=>p.Appo)
        //builder.Entity<Appointment>().HasMany(p=>p.Pet).WithOne(p=>p.Appo)


// -------------------------- Client Entity ----------------------------
        builder.Entity<Client>().ToTable("Clients");
        builder.Entity<Client>().HasKey(p => p.Id);
        builder.Entity<Client>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Client>().Property(p => p.Name)
            .IsRequired().HasMaxLength(40);
        // -------------------------- Doctor Entity ----------------------------
        builder.Entity<Doctor>().ToTable("Doctors");
        builder.Entity<Doctor>().HasKey(p => p.Id);
        builder.Entity<Doctor>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Doctor>().Property(p => p.Name)
            .IsRequired().HasMaxLength(40);
        // -------------------------- Veterinary Entity ----------------------------
        builder.Entity<Veterinary>().ToTable("Veterinaries");
        builder.Entity<Veterinary>().HasKey(p => p.Id);
        builder.Entity<Veterinary>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
        builder.Entity<Veterinary>().Property(p => p.Name)
            .IsRequired().HasMaxLength(40);




        builder.UseSnakeCaseNamingConvention();
    }
}